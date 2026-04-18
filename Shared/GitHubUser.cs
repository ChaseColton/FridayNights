using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    public class GitHubUser
    {
        public string Login { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        // Add other properties you need from the GitHub API response
    }

}
