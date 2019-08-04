using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using YamlDotNet.RepresentationModel;

namespace GitHubLanguageStatistics
{
    class Model : IModel
    {
        public void AddColors(SortableBindingList<Language> dataSourceByProject, SortableBindingList<Language> dataSourceByLinesOfCode)
        {
            string yamlString = GetContentFromUrl("https://raw.githubusercontent.com/github/linguist/master/lib/linguist/languages.yml");

            // Load the stream.
            YamlStream yaml = new YamlStream();
            using (StringReader input = new StringReader(yamlString))
                yaml.Load(input);

            // Examine the stream.
            YamlMappingNode mapping = (YamlMappingNode)yaml.Documents[0].RootNode;

            foreach (Language language in dataSourceByProject)
            {
                string colorHex = ((YamlScalarNode)new Dictionary<YamlNode, YamlNode>(((YamlMappingNode)mapping.Children.FirstOrDefault(x => x.Key.ToString() == language.LanguageName).Value).Children).FirstOrDefault(x => x.Key.ToString() == "color").Value).Value;
                language.Color = System.Drawing.ColorTranslator.FromHtml(colorHex);
            }
            foreach (Language language in dataSourceByLinesOfCode)
            {
                string colorHex = ((YamlScalarNode)new Dictionary<YamlNode, YamlNode>(((YamlMappingNode)mapping.Children.FirstOrDefault(x => x.Key.ToString() == language.LanguageName).Value).Children).FirstOrDefault(x => x.Key.ToString() == "color").Value).Value;
                language.Color = System.Drawing.ColorTranslator.FromHtml(colorHex);
            }
        }

        public void UpdateList(SortableBindingList<Language> dataSourceByProject, SortableBindingList<Language> dataSourceByLinesOfCode, string userName)
        {
            string json = GetContentFromUrl($"https://api.github.com/users/{userName}/repos");
            JArray array = JArray.Parse(json);
            foreach (JToken element in array)
            {
                AddCountToList(dataSourceByProject, element["language"].ToString(), 1);
                string repoName = element["name"].ToString();
                string subJson = GetContentFromUrl($"https://api.github.com/repos/{userName}/{repoName}/languages");
                JObject repoObject = JObject.Parse(subJson);
                foreach (KeyValuePair<string, JToken> thing in repoObject)
                {
                    AddCountToList(dataSourceByLinesOfCode, thing.Key, (int)thing.Value);
                }
            }
            dataSourceByProject.OrderByDescending(x => x.Count);
            dataSourceByLinesOfCode.OrderByDescending(x => x.Count);
        }

        private void AddCountToList(SortableBindingList<Language> dataSource, string languageName, int count)
        {
            var item = dataSource.FirstOrDefault(x => x.LanguageName == languageName);
            if (item == null)
                dataSource.Add(new Language { LanguageName = languageName, Count = count });
            else
                item.Count += count;
        }

        private string GetContentFromUrl(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json; charset=utf-8";
            request.UserAgent = "request";

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream, Encoding.UTF8))
                return reader.ReadToEnd();
        }
    }
}
