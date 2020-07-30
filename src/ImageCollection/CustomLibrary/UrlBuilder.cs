using System.Collections.Generic;

namespace PuzzleTag.ImageCollection.CustomLibrary
{
    class UrlBuilder
    {
        private string url;
        private List<string> args;

        public UrlBuilder(string baseUrl)
        {
            if (!baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl + "/";
            }

            this.url = baseUrl;
            this.args = new List<string>();
        }

        public string Url => url;

        public UrlBuilder AddSection(string section)
        {
            if (section.StartsWith("/"))
            {
                section = section.Substring(1, section.Length);
            }

            var modifiedUrl = this.url + $"{section}";

            if (!modifiedUrl.EndsWith("/"))
            {
                modifiedUrl = modifiedUrl + "/";
            }

            this.url = modifiedUrl;

            return this;
        }

        public UrlBuilder AddParams(string[] args)
        {
            foreach (var s in args)
            {
                this.args.Add(s);
            }

            return this;
        }

        public UrlBuilder Build()
        {
            var modifiedUrl = this.url;
            string parameters = string.Empty;

            if (this.args.Count > 0)
            {
                modifiedUrl += "?";

                foreach (var s in this.args)
                {
                    parameters = s + ",";
                }

                parameters = parameters.Remove(parameters.Length - 1);
            }

            modifiedUrl += parameters;

            this.url = modifiedUrl;
            return this;
        }
    }
}
