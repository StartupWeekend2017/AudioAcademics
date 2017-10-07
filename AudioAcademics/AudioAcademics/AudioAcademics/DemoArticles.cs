using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioAcademics.Models;

namespace AudioAcademics
{
    public static class DemoArticles
    {
        public static List<Article> Articles = new List<Article>()
        {
            new Article()
            {
                Id = 11,
                AudioUrl = "https://phoodfridge.blob.core.windows.net/audibleacademics/142.mp3",
                Title = "7 Management Practices",
                Contents = "Here are some management practice you should start doing two weeks ago."
            },
            new Article()
            {
                Id = 54,
                AudioUrl = "https://phoodfridge.blob.core.windows.net/audibleacademics/95.mp3",
                Title = "Something about a skunk",
                Contents = "Something about a skunk, I think. I should have been paying more attention."
            }
        };
    }
}
