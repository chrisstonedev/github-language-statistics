using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GitHubLanguageStatistics
{
    /// <summary>
    /// Provides a generic collection that supports data binding and additionally supports sorting.
    /// See http://msdn.microsoft.com/en-us/library/ms993236.aspx
    /// If the elements are IComparable it uses that; otherwise compares the ToString().
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    public class SortableBindingList<T> : BindingList<T> where T : class
    {
        private bool isSorted;
        private ListSortDirection sortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor sortProperty;

        /// <summary>
        /// Initializes a new instance of the <see cref="SortableBindingList{T}"/> class.
        /// </summary>
        public SortableBindingList() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortableBindingList{T}"/> class.
        /// </summary>
        /// <param name="list">A <see cref="List{T}"/> of items to be contained in the <see cref="BindingList{T}"/>.</param>
        public SortableBindingList(IList<T> list) : base(list) { }

        /// <summary>
        /// Gets a value indicating whether the list supports sorting.
        /// </summary>
        protected override bool SupportsSortingCore => true;

        /// <summary>
        /// Gets a value indicating whether the list is sorted.
        /// </summary>
        protected override bool IsSortedCore => isSorted;

        /// <summary>
        /// Gets the direction the list is sorted.
        /// </summary>
        protected override ListSortDirection SortDirectionCore => sortDirection;

        /// <summary>
        /// Gets the property descriptor that is used for sorting the list if sorting is implemented in a derived class; otherwise, returns null.
        /// </summary>
        protected override PropertyDescriptor SortPropertyCore => sortProperty;

        /// <summary>
        /// Removes any sort applied with ApplySortCore if sorting is implemented.
        /// </summary>
        protected override void RemoveSortCore()
        {
            sortDirection = ListSortDirection.Ascending;
            sortProperty = null;
            isSorted = false; //thanks Luca
        }

        /// <summary>
        /// Sorts the items if overridden in a derived class.
        /// </summary>
        /// <param name="property">The property to which sorting is being applied.</param>
        /// <param name="direction">The direction of the sort request.</param>
        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            sortProperty = property;
            sortDirection = direction;

            if (!(Items is List<T> list)) return;

            list.Sort(Compare);

            isSorted = true;
            // Fire an event that the list has been changed.
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        private int Compare(T lhs, T rhs)
        {
            int result = OnComparison(lhs, rhs);
            // Invert if descending.
            if (sortDirection == ListSortDirection.Descending)
                result = -result;
            return result;
        }

        private int OnComparison(T lhs, T rhs)
        {
            object lhsValue = lhs == null ? null : sortProperty.GetValue(lhs);
            object rhsValue = rhs == null ? null : sortProperty.GetValue(rhs);
            if (lhsValue == null) // Either both are null (and thus equal) or the second value is greater.
                return rhsValue == null ? 0 : -1;
            if (rhsValue == null) // First value is not null, so if second doesn't, first is greater.
                return 1;
            if (lhsValue is IComparable) // Use CompareTo in IComparable implementation, if applicable.
                return ((IComparable)lhsValue).CompareTo(rhsValue);
            if (lhsValue.Equals(rhsValue)) // Use Equals implementation to see if both are equal.
                return 0;
            // Values are not equal, not null, and not comparable; compare using ToString.
            return lhsValue.ToString().CompareTo(rhsValue.ToString());
        }
    }
}
