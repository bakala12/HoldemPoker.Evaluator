namespace HoldemPoker.Evaluator.Tests.Utils;

internal static class HandsProvider
    {
        public static IEnumerable<ulong> GetAllRoyalFlushes()
        {
            for (int i = 0; i < 4; i++)
                yield return 0x1111100000000UL << i;
        }

        public static IEnumerable<ulong> GetAllStraightFlushes()
        {
            for (int i = 0; i < 4; i++)
            {
                yield return 0x1000000001111UL << i;
                for (int m = 0; m < 8; m++)
                    yield return 0x11111UL << (4 * m + i);
            }
        }

        public static IEnumerable<ulong> GetAllFourOfAKinds()
        {
            for (int i = 0; i < 13; i++)
                for (int j = 0; j < 52; j++)
                    if (j / 4 != i)
                        yield return (0xFUL << 4 * i) | (1UL << j);
        }

        public static IEnumerable<ulong> GetAllFullHouses()
        {
            foreach (var (ut, t) in GetTriples())
                foreach (var (up, p) in GetPairs())
                    if (t != p)
                        yield return up | ut;
        }

        public static IEnumerable<ulong> GetAllFlushes()
        {
            for (int c = 0; c < 4; c++)
                for (int t1 = 4; t1 < 13; t1++)
                    for (int t2 = 3; t2 < t1; t2++)
                        for (int t3 = 2; t3 < t2; t3++)
                            for (int t4 = 1; t4 < t3; t4++)
                                for (int t5 = 0; t5 < t4; t5++)
                                    if (!IsStraight(t1, t2, t3, t4, t5))
                                        yield return (1UL << (4 * t1 + c)) | (1UL << (4 * t2 + c)) | (1UL << (4 * t3 + c)) | (1UL << (4 * t4 + c)) | (1UL << (4 * t5 + c));
        }

        public static IEnumerable<ulong> GetAllStraights()
        {
            for (int max = 3; max < 13; max++)
            {
                var t1 = max;
                var t2 = max - 1;
                var t3 = max - 2;
                var t4 = max - 3;
                var t5 = max == 3 ? 12 : max - 4;
                for (int c1 = 0; c1 < 4; c1++)
                    for (int c2 = 0; c2 < 4; c2++)
                        for (int c3 = 0; c3 < 4; c3++)
                            for (int c4 = 0; c4 < 4; c4++)
                                for (int c5 = 0; c5 < 4; c5++)
                                    if (!(c1 == c2 && c1 == c3 && c1 == c4 && c1 == c5))
                                        yield return (1UL << (4 * t1 + c1)) | (1UL << (4 * t2 + c2)) | (1UL << (4 * t3 + c3)) | (1UL << (4 * t4 + c4)) | (1UL << (4 * t5 + c5));
            }
        }

        public static IEnumerable<ulong> GetAllThreeOfAKinds()
        {
            foreach (var (ut, t) in GetTriples())
                for (int k1 = 1; k1 < 13; k1++)
                    for (int k2 = 0; k2 < k1; k2++)
                        if (t != k1 && t != k2)
                            for (int c1 = 0; c1 < 4; c1++)
                                for (int c2 = 0; c2 < 4; c2++)
                                    yield return ut | (1UL << (4 * k1 + c1)) | (1UL << (4 * k2 + c2));
        }

        public static IEnumerable<ulong> GetAllTwoPairs()
        {
            foreach (var (up1, p1) in GetPairs())
                foreach (var (up2, p2) in GetPairs())
                    for (int k = 0; k < 13; k++)
                        if (p1 > p2 && p1 != k && p2 != k)
                            for (int c = 0; c < 4; c++)
                                yield return up1 | up2 | (1UL << (4 * k + c));
        }

        public static IEnumerable<ulong> GetAllOnePairs()
        {
            foreach (var (up, p) in GetPairs())
                for (int k1 = 2; k1 < 13; k1++)
                    for (int k2 = 1; k2 < k1; k2++)
                        for (int k3 = 0; k3 < k2; k3++)
                            if (p != k1 && p != k2 && p != k3)
                                for (int c1 = 0; c1 < 4; c1++)
                                    for (int c2 = 0; c2 < 4; c2++)
                                        for (int c3 = 0; c3 < 4; c3++)
                                            yield return up | (1UL << (4 * k1 + c1)) | (1UL << (4 * k2 + c2)) | (1UL << (4 * k3 + c3));
        }

        public static IEnumerable<ulong> GetAllHighCards()
        {
            for (int t1 = 4; t1 < 13; t1++)
                for (int t2 = 3; t2 < t1; t2++)
                    for (int t3 = 2; t3 < t2; t3++)
                        for (int t4 = 1; t4 < t3; t4++)
                            for (int t5 = 0; t5 < t4; t5++)
                                if (!IsStraight(t1, t2, t3, t4, t5))
                                    for (int c1 = 0; c1 < 4; c1++)
                                        for (int c2 = 0; c2 < 4; c2++)
                                            for (int c3 = 0; c3 < 4; c3++)
                                                for (int c4 = 0; c4 < 4; c4++)
                                                    for (int c5 = 0; c5 < 4; c5++)
                                                        if (!(c1 == c2 && c1 == c3 && c1 == c4 && c1 == c5))
                                                            yield return (1UL << (4 * t1 + c1)) | (1UL << (4 * t2 + c2)) | (1UL << (4 * t3 + c3)) | (1UL << (4 * t4 + c4)) | (1UL << (4 * t5 + c5));
        }

        private static IEnumerable<(ulong, int)> GetTriples()
        {
            for (int t = 0; t < 13; t++)
                for (int tc = 0; tc < 4; tc++)
                    yield return ((0xFUL ^ (1UL << tc)) << (4 * t), t);
        }

        private static IEnumerable<(ulong, int)> GetPairs()
        {
            for (int t = 0; t < 13; t++)
                for (int c1 = 1; c1 < 4; c1++)
                    for (int c2 = 0; c2 < c1; c2++)
                        yield return (((1UL << c1) | (1UL << c2)) << (4 * t), t);
        }

        private static bool IsStraight(int t1, int t2, int t3, int t4, int t5)
        {
            return t4 - t5 == 1 && t3 - t4 == 1 && t2 - t3 == 1 && (t1 - t2 == 1 || (t1 == 12 && t5 == 0));
        }
    }