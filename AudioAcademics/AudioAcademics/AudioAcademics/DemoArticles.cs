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
                Id = 3,
                AudioUrl = "https://phoodfridge.blob.core.windows.net/audibleacademics/GravitationalWaves.mp3",
                Title =
                    "THE LASER INTERFEROMETER GRAVITATIONAL-WAVE OBSERVATORY AND THE FIRST DIRECT OBSERVATION OF GRAVITATIONAL WAVES",
                Author = "The Nobel Committee for Physics",
                Contents =
                    "Our knowledge and understanding of the Universe is based on millennia of observations of the quanta of electromagnetic radiation – photons – in a wide range of wavelengths. These studies have taught us a lot – not only about planets, stars and galaxies but also about the origins of structure, the evolution and possibly the fate of the Universe. It turns out, however, that highly energetic photons do not reach us from the furthest recesses of the cosmos. So, during the past few decades, new kinds of telescopes have been developed, leading to unexpected breakthroughs. These detectors exploit other forms of radiation: cosmic rays, neutrinos and gravitational waves.",
                CitationUrl = "https://www.nobelprize.org/nobel_prizes/physics/laureates/2017/advanced-physicsprize2017.pdf",
                ImageUrl = "https://blog.gainesvillecoins.com/wp-content/uploads/2014/03/20131011153017Nobel_Prize-300x295.png"
            },
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