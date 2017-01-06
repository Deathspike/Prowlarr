﻿using System.Collections.Generic;

namespace NzbDrone.Core.Tv
{
    public static class MovieTitleNormalizer
    {
        private readonly static Dictionary<int, string> PreComputedTitles = new Dictionary<int, string>
                                                                     {
                                                                         { 999999999, "a to z" },
                                                                     };

        public static string Normalize(string title, int tmdbid)
        {
            if (PreComputedTitles.ContainsKey(tmdbid))
            {
                return PreComputedTitles[tmdbid];
            }

            return Parser.Parser.NormalizeTitle(title).ToLower();
        }
    }
}
