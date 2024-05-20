/*
 *  Copyright 2016-2019 Henry Lee
 *  Ported from C++ to C# 2024 Mateusz Bąkała
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

namespace HoldemPoker.Evaluator.Hashtables;

/// <summary>
/// There is 7462 separate equivalence classes of poker hands starting from royal flush to high card with 7.
/// The array in this class lists them all and in the comment there is a card sequence that creates that hand.
/// For flushes (including straight and royal flushes) it is implicitly assumed that all cards are in the same color.
/// </summary>
internal static class PokerHandRankings
{
    internal static string[] PokerHands = new string[7463]
    {
        "", //guard
        "Royal Flush",	//AKQJT
        "King-High Straight Flush",	//KQJT9
        "Queen-High Straight Flush",	//QJT98
        "Jack-High Straight Flush",	//JT987
        "Ten-High Straight Flush",	//T9876
        "Nine-High Straight Flush",	//98765
        "Eight-High Straight Flush",	//87654
        "Seven-High Straight Flush",	//76543
        "Six-High Straight Flush",	//65432
        "Five-High Straight Flush",	//5432A
        "Four Aces",	//AAAAK
        "Four Aces",	//AAAAQ
        "Four Aces",	//AAAAJ
        "Four Aces",	//AAAAT
        "Four Aces",	//AAAA9
        "Four Aces",	//AAAA8
        "Four Aces",	//AAAA7
        "Four Aces",	//AAAA6
        "Four Aces",	//AAAA5
        "Four Aces",	//AAAA4
        "Four Aces",	//AAAA3
        "Four Aces",	//AAAA2
        "Four Kings",	//KKKKA
        "Four Kings",	//KKKKQ
        "Four Kings",	//KKKKJ
        "Four Kings",	//KKKKT
        "Four Kings",	//KKKK9
        "Four Kings",	//KKKK8
        "Four Kings",	//KKKK7
        "Four Kings",	//KKKK6
        "Four Kings",	//KKKK5
        "Four Kings",	//KKKK4
        "Four Kings",	//KKKK3
        "Four Kings",	//KKKK2
        "Four Queens",	//QQQQA
        "Four Queens",	//QQQQK
        "Four Queens",	//QQQQJ
        "Four Queens",	//QQQQT
        "Four Queens",	//QQQQ9
        "Four Queens",	//QQQQ8
        "Four Queens",	//QQQQ7
        "Four Queens",	//QQQQ6
        "Four Queens",	//QQQQ5
        "Four Queens",	//QQQQ4
        "Four Queens",	//QQQQ3
        "Four Queens",	//QQQQ2
        "Four Jacks",	//JJJJA
        "Four Jacks",	//JJJJK
        "Four Jacks",	//JJJJQ
        "Four Jacks",	//JJJJT
        "Four Jacks",	//JJJJ9
        "Four Jacks",	//JJJJ8
        "Four Jacks",	//JJJJ7
        "Four Jacks",	//JJJJ6
        "Four Jacks",	//JJJJ5
        "Four Jacks",	//JJJJ4
        "Four Jacks",	//JJJJ3
        "Four Jacks",	//JJJJ2
        "Four Tens",	//TTTTA
        "Four Tens",	//TTTTK
        "Four Tens",	//TTTTQ
        "Four Tens",	//TTTTJ
        "Four Tens",	//TTTT9
        "Four Tens",	//TTTT8
        "Four Tens",	//TTTT7
        "Four Tens",	//TTTT6
        "Four Tens",	//TTTT5
        "Four Tens",	//TTTT4
        "Four Tens",	//TTTT3
        "Four Tens",	//TTTT2
        "Four Nines",	//9999A
        "Four Nines",	//9999K
        "Four Nines",	//9999Q
        "Four Nines",	//9999J
        "Four Nines",	//9999T
        "Four Nines",	//99998
        "Four Nines",	//99997
        "Four Nines",	//99996
        "Four Nines",	//99995
        "Four Nines",	//99994
        "Four Nines",	//99993
        "Four Nines",	//99992
        "Four Eights",	//8888A
        "Four Eights",	//8888K
        "Four Eights",	//8888Q
        "Four Eights",	//8888J
        "Four Eights",	//8888T
        "Four Eights",	//88889
        "Four Eights",	//88887
        "Four Eights",	//88886
        "Four Eights",	//88885
        "Four Eights",	//88884
        "Four Eights",	//88883
        "Four Eights",	//88882
        "Four Sevens",	//7777A
        "Four Sevens",	//7777K
        "Four Sevens",	//7777Q
        "Four Sevens",	//7777J
        "Four Sevens",	//7777T
        "Four Sevens",	//77779
        "Four Sevens",	//77778
        "Four Sevens",	//77776
        "Four Sevens",	//77775
        "Four Sevens",	//77774
        "Four Sevens",	//77773
        "Four Sevens",	//77772
        "Four Sixes",	//6666A
        "Four Sixes",	//6666K
        "Four Sixes",	//6666Q
        "Four Sixes",	//6666J
        "Four Sixes",	//6666T
        "Four Sixes",	//66669
        "Four Sixes",	//66668
        "Four Sixes",	//66667
        "Four Sixes",	//66665
        "Four Sixes",	//66664
        "Four Sixes",	//66663
        "Four Sixes",	//66662
        "Four Fives",	//5555A
        "Four Fives",	//5555K
        "Four Fives",	//5555Q
        "Four Fives",	//5555J
        "Four Fives",	//5555T
        "Four Fives",	//55559
        "Four Fives",	//55558
        "Four Fives",	//55557
        "Four Fives",	//55556
        "Four Fives",	//55554
        "Four Fives",	//55553
        "Four Fives",	//55552
        "Four Fours",	//4444A
        "Four Fours",	//4444K
        "Four Fours",	//4444Q
        "Four Fours",	//4444J
        "Four Fours",	//4444T
        "Four Fours",	//44449
        "Four Fours",	//44448
        "Four Fours",	//44447
        "Four Fours",	//44446
        "Four Fours",	//44445
        "Four Fours",	//44443
        "Four Fours",	//44442
        "Four Treys",	//3333A
        "Four Treys",	//3333K
        "Four Treys",	//3333Q
        "Four Treys",	//3333J
        "Four Treys",	//3333T
        "Four Treys",	//33339
        "Four Treys",	//33338
        "Four Treys",	//33337
        "Four Treys",	//33336
        "Four Treys",	//33335
        "Four Treys",	//33334
        "Four Treys",	//33332
        "Four Deuces",	//2222A
        "Four Deuces",	//2222K
        "Four Deuces",	//2222Q
        "Four Deuces",	//2222J
        "Four Deuces",	//2222T
        "Four Deuces",	//22229
        "Four Deuces",	//22228
        "Four Deuces",	//22227
        "Four Deuces",	//22226
        "Four Deuces",	//22225
        "Four Deuces",	//22224
        "Four Deuces",	//22223
        "Aces Full over Kings",	//AAAKK
        "Aces Full over Queens",	//AAAQQ
        "Aces Full over Jacks",	//AAAJJ
        "Aces Full over Tens",	//AAATT
        "Aces Full over Nines",	//AAA99
        "Aces Full over Eights",	//AAA88
        "Aces Full over Sevens",	//AAA77
        "Aces Full over Sixes",	//AAA66
        "Aces Full over Fives",	//AAA55
        "Aces Full over Fours",	//AAA44
        "Aces Full over Treys",	//AAA33
        "Aces Full over Deuces",	//AAA22
        "Kings Full over Aces",	//KKKAA
        "Kings Full over Queens",	//KKKQQ
        "Kings Full over Jacks",	//KKKJJ
        "Kings Full over Tens",	//KKKTT
        "Kings Full over Nines",	//KKK99
        "Kings Full over Eights",	//KKK88
        "Kings Full over Sevens",	//KKK77
        "Kings Full over Sixes",	//KKK66
        "Kings Full over Fives",	//KKK55
        "Kings Full over Fours",	//KKK44
        "Kings Full over Treys",	//KKK33
        "Kings Full over Deuces",	//KKK22
        "Queens Full over Aces",	//QQQAA
        "Queens Full over Kings",	//QQQKK
        "Queens Full over Jacks",	//QQQJJ
        "Queens Full over Tens",	//QQQTT
        "Queens Full over Nines",	//QQQ99
        "Queens Full over Eights",	//QQQ88
        "Queens Full over Sevens",	//QQQ77
        "Queens Full over Sixes",	//QQQ66
        "Queens Full over Fives",	//QQQ55
        "Queens Full over Fours",	//QQQ44
        "Queens Full over Treys",	//QQQ33
        "Queens Full over Deuces",	//QQQ22
        "Jacks Full over Aces",	//JJJAA
        "Jacks Full over Kings",	//JJJKK
        "Jacks Full over Queens",	//JJJQQ
        "Jacks Full over Tens",	//JJJTT
        "Jacks Full over Nines",	//JJJ99
        "Jacks Full over Eights",	//JJJ88
        "Jacks Full over Sevens",	//JJJ77
        "Jacks Full over Sixes",	//JJJ66
        "Jacks Full over Fives",	//JJJ55
        "Jacks Full over Fours",	//JJJ44
        "Jacks Full over Treys",	//JJJ33
        "Jacks Full over Deuces",	//JJJ22
        "Tens Full over Aces",	//TTTAA
        "Tens Full over Kings",	//TTTKK
        "Tens Full over Queens",	//TTTQQ
        "Tens Full over Jacks",	//TTTJJ
        "Tens Full over Nines",	//TTT99
        "Tens Full over Eights",	//TTT88
        "Tens Full over Sevens",	//TTT77
        "Tens Full over Sixes",	//TTT66
        "Tens Full over Fives",	//TTT55
        "Tens Full over Fours",	//TTT44
        "Tens Full over Treys",	//TTT33
        "Tens Full over Deuces",	//TTT22
        "Nines Full over Aces",	//999AA
        "Nines Full over Kings",	//999KK
        "Nines Full over Queens",	//999QQ
        "Nines Full over Jacks",	//999JJ
        "Nines Full over Tens",	//999TT
        "Nines Full over Eights",	//99988
        "Nines Full over Sevens",	//99977
        "Nines Full over Sixes",	//99966
        "Nines Full over Fives",	//99955
        "Nines Full over Fours",	//99944
        "Nines Full over Treys",	//99933
        "Nines Full over Deuces",	//99922
        "Eights Full over Aces",	//888AA
        "Eights Full over Kings",	//888KK
        "Eights Full over Queens",	//888QQ
        "Eights Full over Jacks",	//888JJ
        "Eights Full over Tens",	//888TT
        "Eights Full over Nines",	//88899
        "Eights Full over Sevens",	//88877
        "Eights Full over Sixes",	//88866
        "Eights Full over Fives",	//88855
        "Eights Full over Fours",	//88844
        "Eights Full over Treys",	//88833
        "Eights Full over Deuces",	//88822
        "Sevens Full over Aces",	//777AA
        "Sevens Full over Kings",	//777KK
        "Sevens Full over Queens",	//777QQ
        "Sevens Full over Jacks",	//777JJ
        "Sevens Full over Tens",	//777TT
        "Sevens Full over Nines",	//77799
        "Sevens Full over Eights",	//77788
        "Sevens Full over Sixes",	//77766
        "Sevens Full over Fives",	//77755
        "Sevens Full over Fours",	//77744
        "Sevens Full over Treys",	//77733
        "Sevens Full over Deuces",	//77722
        "Sixes Full over Aces",	//666AA
        "Sixes Full over Kings",	//666KK
        "Sixes Full over Queens",	//666QQ
        "Sixes Full over Jacks",	//666JJ
        "Sixes Full over Tens",	//666TT
        "Sixes Full over Nines",	//66699
        "Sixes Full over Eights",	//66688
        "Sixes Full over Sevens",	//66677
        "Sixes Full over Fives",	//66655
        "Sixes Full over Fours",	//66644
        "Sixes Full over Treys",	//66633
        "Sixes Full over Deuces",	//66622
        "Fives Full over Aces",	//555AA
        "Fives Full over Kings",	//555KK
        "Fives Full over Queens",	//555QQ
        "Fives Full over Jacks",	//555JJ
        "Fives Full over Tens",	//555TT
        "Fives Full over Nines",	//55599
        "Fives Full over Eights",	//55588
        "Fives Full over Sevens",	//55577
        "Fives Full over Sixes",	//55566
        "Fives Full over Fours",	//55544
        "Fives Full over Treys",	//55533
        "Fives Full over Deuces",	//55522
        "Fours Full over Aces",	//444AA
        "Fours Full over Kings",	//444KK
        "Fours Full over Queens",	//444QQ
        "Fours Full over Jacks",	//444JJ
        "Fours Full over Tens",	//444TT
        "Fours Full over Nines",	//44499
        "Fours Full over Eights",	//44488
        "Fours Full over Sevens",	//44477
        "Fours Full over Sixes",	//44466
        "Fours Full over Fives",	//44455
        "Fours Full over Treys",	//44433
        "Fours Full over Deuces",	//44422
        "Treys Full over Aces",	//333AA
        "Treys Full over Kings",	//333KK
        "Treys Full over Queens",	//333QQ
        "Treys Full over Jacks",	//333JJ
        "Treys Full over Tens",	//333TT
        "Treys Full over Nines",	//33399
        "Treys Full over Eights",	//33388
        "Treys Full over Sevens",	//33377
        "Treys Full over Sixes",	//33366
        "Treys Full over Fives",	//33355
        "Treys Full over Fours",	//33344
        "Treys Full over Deuces",	//33322
        "Deuces Full over Aces",	//222AA
        "Deuces Full over Kings",	//222KK
        "Deuces Full over Queens",	//222QQ
        "Deuces Full over Jacks",	//222JJ
        "Deuces Full over Tens",	//222TT
        "Deuces Full over Nines",	//22299
        "Deuces Full over Eights",	//22288
        "Deuces Full over Sevens",	//22277
        "Deuces Full over Sixes",	//22266
        "Deuces Full over Fives",	//22255
        "Deuces Full over Fours",	//22244
        "Deuces Full over Treys",	//22233
        "Ace-High Flush",	//AKQJ9
        "Ace-High Flush",	//AKQJ8
        "Ace-High Flush",	//AKQJ7
        "Ace-High Flush",	//AKQJ6
        "Ace-High Flush",	//AKQJ5
        "Ace-High Flush",	//AKQJ4
        "Ace-High Flush",	//AKQJ3
        "Ace-High Flush",	//AKQJ2
        "Ace-High Flush",	//AKQT9
        "Ace-High Flush",	//AKQT8
        "Ace-High Flush",	//AKQT7
        "Ace-High Flush",	//AKQT6
        "Ace-High Flush",	//AKQT5
        "Ace-High Flush",	//AKQT4
        "Ace-High Flush",	//AKQT3
        "Ace-High Flush",	//AKQT2
        "Ace-High Flush",	//AKQ98
        "Ace-High Flush",	//AKQ97
        "Ace-High Flush",	//AKQ96
        "Ace-High Flush",	//AKQ95
        "Ace-High Flush",	//AKQ94
        "Ace-High Flush",	//AKQ93
        "Ace-High Flush",	//AKQ92
        "Ace-High Flush",	//AKQ87
        "Ace-High Flush",	//AKQ86
        "Ace-High Flush",	//AKQ85
        "Ace-High Flush",	//AKQ84
        "Ace-High Flush",	//AKQ83
        "Ace-High Flush",	//AKQ82
        "Ace-High Flush",	//AKQ76
        "Ace-High Flush",	//AKQ75
        "Ace-High Flush",	//AKQ74
        "Ace-High Flush",	//AKQ73
        "Ace-High Flush",	//AKQ72
        "Ace-High Flush",	//AKQ65
        "Ace-High Flush",	//AKQ64
        "Ace-High Flush",	//AKQ63
        "Ace-High Flush",	//AKQ62
        "Ace-High Flush",	//AKQ54
        "Ace-High Flush",	//AKQ53
        "Ace-High Flush",	//AKQ52
        "Ace-High Flush",	//AKQ43
        "Ace-High Flush",	//AKQ42
        "Ace-High Flush",	//AKQ32
        "Ace-High Flush",	//AKJT9
        "Ace-High Flush",	//AKJT8
        "Ace-High Flush",	//AKJT7
        "Ace-High Flush",	//AKJT6
        "Ace-High Flush",	//AKJT5
        "Ace-High Flush",	//AKJT4
        "Ace-High Flush",	//AKJT3
        "Ace-High Flush",	//AKJT2
        "Ace-High Flush",	//AKJ98
        "Ace-High Flush",	//AKJ97
        "Ace-High Flush",	//AKJ96
        "Ace-High Flush",	//AKJ95
        "Ace-High Flush",	//AKJ94
        "Ace-High Flush",	//AKJ93
        "Ace-High Flush",	//AKJ92
        "Ace-High Flush",	//AKJ87
        "Ace-High Flush",	//AKJ86
        "Ace-High Flush",	//AKJ85
        "Ace-High Flush",	//AKJ84
        "Ace-High Flush",	//AKJ83
        "Ace-High Flush",	//AKJ82
        "Ace-High Flush",	//AKJ76
        "Ace-High Flush",	//AKJ75
        "Ace-High Flush",	//AKJ74
        "Ace-High Flush",	//AKJ73
        "Ace-High Flush",	//AKJ72
        "Ace-High Flush",	//AKJ65
        "Ace-High Flush",	//AKJ64
        "Ace-High Flush",	//AKJ63
        "Ace-High Flush",	//AKJ62
        "Ace-High Flush",	//AKJ54
        "Ace-High Flush",	//AKJ53
        "Ace-High Flush",	//AKJ52
        "Ace-High Flush",	//AKJ43
        "Ace-High Flush",	//AKJ42
        "Ace-High Flush",	//AKJ32
        "Ace-High Flush",	//AKT98
        "Ace-High Flush",	//AKT97
        "Ace-High Flush",	//AKT96
        "Ace-High Flush",	//AKT95
        "Ace-High Flush",	//AKT94
        "Ace-High Flush",	//AKT93
        "Ace-High Flush",	//AKT92
        "Ace-High Flush",	//AKT87
        "Ace-High Flush",	//AKT86
        "Ace-High Flush",	//AKT85
        "Ace-High Flush",	//AKT84
        "Ace-High Flush",	//AKT83
        "Ace-High Flush",	//AKT82
        "Ace-High Flush",	//AKT76
        "Ace-High Flush",	//AKT75
        "Ace-High Flush",	//AKT74
        "Ace-High Flush",	//AKT73
        "Ace-High Flush",	//AKT72
        "Ace-High Flush",	//AKT65
        "Ace-High Flush",	//AKT64
        "Ace-High Flush",	//AKT63
        "Ace-High Flush",	//AKT62
        "Ace-High Flush",	//AKT54
        "Ace-High Flush",	//AKT53
        "Ace-High Flush",	//AKT52
        "Ace-High Flush",	//AKT43
        "Ace-High Flush",	//AKT42
        "Ace-High Flush",	//AKT32
        "Ace-High Flush",	//AK987
        "Ace-High Flush",	//AK986
        "Ace-High Flush",	//AK985
        "Ace-High Flush",	//AK984
        "Ace-High Flush",	//AK983
        "Ace-High Flush",	//AK982
        "Ace-High Flush",	//AK976
        "Ace-High Flush",	//AK975
        "Ace-High Flush",	//AK974
        "Ace-High Flush",	//AK973
        "Ace-High Flush",	//AK972
        "Ace-High Flush",	//AK965
        "Ace-High Flush",	//AK964
        "Ace-High Flush",	//AK963
        "Ace-High Flush",	//AK962
        "Ace-High Flush",	//AK954
        "Ace-High Flush",	//AK953
        "Ace-High Flush",	//AK952
        "Ace-High Flush",	//AK943
        "Ace-High Flush",	//AK942
        "Ace-High Flush",	//AK932
        "Ace-High Flush",	//AK876
        "Ace-High Flush",	//AK875
        "Ace-High Flush",	//AK874
        "Ace-High Flush",	//AK873
        "Ace-High Flush",	//AK872
        "Ace-High Flush",	//AK865
        "Ace-High Flush",	//AK864
        "Ace-High Flush",	//AK863
        "Ace-High Flush",	//AK862
        "Ace-High Flush",	//AK854
        "Ace-High Flush",	//AK853
        "Ace-High Flush",	//AK852
        "Ace-High Flush",	//AK843
        "Ace-High Flush",	//AK842
        "Ace-High Flush",	//AK832
        "Ace-High Flush",	//AK765
        "Ace-High Flush",	//AK764
        "Ace-High Flush",	//AK763
        "Ace-High Flush",	//AK762
        "Ace-High Flush",	//AK754
        "Ace-High Flush",	//AK753
        "Ace-High Flush",	//AK752
        "Ace-High Flush",	//AK743
        "Ace-High Flush",	//AK742
        "Ace-High Flush",	//AK732
        "Ace-High Flush",	//AK654
        "Ace-High Flush",	//AK653
        "Ace-High Flush",	//AK652
        "Ace-High Flush",	//AK643
        "Ace-High Flush",	//AK642
        "Ace-High Flush",	//AK632
        "Ace-High Flush",	//AK543
        "Ace-High Flush",	//AK542
        "Ace-High Flush",	//AK532
        "Ace-High Flush",	//AK432
        "Ace-High Flush",	//AQJT9
        "Ace-High Flush",	//AQJT8
        "Ace-High Flush",	//AQJT7
        "Ace-High Flush",	//AQJT6
        "Ace-High Flush",	//AQJT5
        "Ace-High Flush",	//AQJT4
        "Ace-High Flush",	//AQJT3
        "Ace-High Flush",	//AQJT2
        "Ace-High Flush",	//AQJ98
        "Ace-High Flush",	//AQJ97
        "Ace-High Flush",	//AQJ96
        "Ace-High Flush",	//AQJ95
        "Ace-High Flush",	//AQJ94
        "Ace-High Flush",	//AQJ93
        "Ace-High Flush",	//AQJ92
        "Ace-High Flush",	//AQJ87
        "Ace-High Flush",	//AQJ86
        "Ace-High Flush",	//AQJ85
        "Ace-High Flush",	//AQJ84
        "Ace-High Flush",	//AQJ83
        "Ace-High Flush",	//AQJ82
        "Ace-High Flush",	//AQJ76
        "Ace-High Flush",	//AQJ75
        "Ace-High Flush",	//AQJ74
        "Ace-High Flush",	//AQJ73
        "Ace-High Flush",	//AQJ72
        "Ace-High Flush",	//AQJ65
        "Ace-High Flush",	//AQJ64
        "Ace-High Flush",	//AQJ63
        "Ace-High Flush",	//AQJ62
        "Ace-High Flush",	//AQJ54
        "Ace-High Flush",	//AQJ53
        "Ace-High Flush",	//AQJ52
        "Ace-High Flush",	//AQJ43
        "Ace-High Flush",	//AQJ42
        "Ace-High Flush",	//AQJ32
        "Ace-High Flush",	//AQT98
        "Ace-High Flush",	//AQT97
        "Ace-High Flush",	//AQT96
        "Ace-High Flush",	//AQT95
        "Ace-High Flush",	//AQT94
        "Ace-High Flush",	//AQT93
        "Ace-High Flush",	//AQT92
        "Ace-High Flush",	//AQT87
        "Ace-High Flush",	//AQT86
        "Ace-High Flush",	//AQT85
        "Ace-High Flush",	//AQT84
        "Ace-High Flush",	//AQT83
        "Ace-High Flush",	//AQT82
        "Ace-High Flush",	//AQT76
        "Ace-High Flush",	//AQT75
        "Ace-High Flush",	//AQT74
        "Ace-High Flush",	//AQT73
        "Ace-High Flush",	//AQT72
        "Ace-High Flush",	//AQT65
        "Ace-High Flush",	//AQT64
        "Ace-High Flush",	//AQT63
        "Ace-High Flush",	//AQT62
        "Ace-High Flush",	//AQT54
        "Ace-High Flush",	//AQT53
        "Ace-High Flush",	//AQT52
        "Ace-High Flush",	//AQT43
        "Ace-High Flush",	//AQT42
        "Ace-High Flush",	//AQT32
        "Ace-High Flush",	//AQ987
        "Ace-High Flush",	//AQ986
        "Ace-High Flush",	//AQ985
        "Ace-High Flush",	//AQ984
        "Ace-High Flush",	//AQ983
        "Ace-High Flush",	//AQ982
        "Ace-High Flush",	//AQ976
        "Ace-High Flush",	//AQ975
        "Ace-High Flush",	//AQ974
        "Ace-High Flush",	//AQ973
        "Ace-High Flush",	//AQ972
        "Ace-High Flush",	//AQ965
        "Ace-High Flush",	//AQ964
        "Ace-High Flush",	//AQ963
        "Ace-High Flush",	//AQ962
        "Ace-High Flush",	//AQ954
        "Ace-High Flush",	//AQ953
        "Ace-High Flush",	//AQ952
        "Ace-High Flush",	//AQ943
        "Ace-High Flush",	//AQ942
        "Ace-High Flush",	//AQ932
        "Ace-High Flush",	//AQ876
        "Ace-High Flush",	//AQ875
        "Ace-High Flush",	//AQ874
        "Ace-High Flush",	//AQ873
        "Ace-High Flush",	//AQ872
        "Ace-High Flush",	//AQ865
        "Ace-High Flush",	//AQ864
        "Ace-High Flush",	//AQ863
        "Ace-High Flush",	//AQ862
        "Ace-High Flush",	//AQ854
        "Ace-High Flush",	//AQ853
        "Ace-High Flush",	//AQ852
        "Ace-High Flush",	//AQ843
        "Ace-High Flush",	//AQ842
        "Ace-High Flush",	//AQ832
        "Ace-High Flush",	//AQ765
        "Ace-High Flush",	//AQ764
        "Ace-High Flush",	//AQ763
        "Ace-High Flush",	//AQ762
        "Ace-High Flush",	//AQ754
        "Ace-High Flush",	//AQ753
        "Ace-High Flush",	//AQ752
        "Ace-High Flush",	//AQ743
        "Ace-High Flush",	//AQ742
        "Ace-High Flush",	//AQ732
        "Ace-High Flush",	//AQ654
        "Ace-High Flush",	//AQ653
        "Ace-High Flush",	//AQ652
        "Ace-High Flush",	//AQ643
        "Ace-High Flush",	//AQ642
        "Ace-High Flush",	//AQ632
        "Ace-High Flush",	//AQ543
        "Ace-High Flush",	//AQ542
        "Ace-High Flush",	//AQ532
        "Ace-High Flush",	//AQ432
        "Ace-High Flush",	//AJT98
        "Ace-High Flush",	//AJT97
        "Ace-High Flush",	//AJT96
        "Ace-High Flush",	//AJT95
        "Ace-High Flush",	//AJT94
        "Ace-High Flush",	//AJT93
        "Ace-High Flush",	//AJT92
        "Ace-High Flush",	//AJT87
        "Ace-High Flush",	//AJT86
        "Ace-High Flush",	//AJT85
        "Ace-High Flush",	//AJT84
        "Ace-High Flush",	//AJT83
        "Ace-High Flush",	//AJT82
        "Ace-High Flush",	//AJT76
        "Ace-High Flush",	//AJT75
        "Ace-High Flush",	//AJT74
        "Ace-High Flush",	//AJT73
        "Ace-High Flush",	//AJT72
        "Ace-High Flush",	//AJT65
        "Ace-High Flush",	//AJT64
        "Ace-High Flush",	//AJT63
        "Ace-High Flush",	//AJT62
        "Ace-High Flush",	//AJT54
        "Ace-High Flush",	//AJT53
        "Ace-High Flush",	//AJT52
        "Ace-High Flush",	//AJT43
        "Ace-High Flush",	//AJT42
        "Ace-High Flush",	//AJT32
        "Ace-High Flush",	//AJ987
        "Ace-High Flush",	//AJ986
        "Ace-High Flush",	//AJ985
        "Ace-High Flush",	//AJ984
        "Ace-High Flush",	//AJ983
        "Ace-High Flush",	//AJ982
        "Ace-High Flush",	//AJ976
        "Ace-High Flush",	//AJ975
        "Ace-High Flush",	//AJ974
        "Ace-High Flush",	//AJ973
        "Ace-High Flush",	//AJ972
        "Ace-High Flush",	//AJ965
        "Ace-High Flush",	//AJ964
        "Ace-High Flush",	//AJ963
        "Ace-High Flush",	//AJ962
        "Ace-High Flush",	//AJ954
        "Ace-High Flush",	//AJ953
        "Ace-High Flush",	//AJ952
        "Ace-High Flush",	//AJ943
        "Ace-High Flush",	//AJ942
        "Ace-High Flush",	//AJ932
        "Ace-High Flush",	//AJ876
        "Ace-High Flush",	//AJ875
        "Ace-High Flush",	//AJ874
        "Ace-High Flush",	//AJ873
        "Ace-High Flush",	//AJ872
        "Ace-High Flush",	//AJ865
        "Ace-High Flush",	//AJ864
        "Ace-High Flush",	//AJ863
        "Ace-High Flush",	//AJ862
        "Ace-High Flush",	//AJ854
        "Ace-High Flush",	//AJ853
        "Ace-High Flush",	//AJ852
        "Ace-High Flush",	//AJ843
        "Ace-High Flush",	//AJ842
        "Ace-High Flush",	//AJ832
        "Ace-High Flush",	//AJ765
        "Ace-High Flush",	//AJ764
        "Ace-High Flush",	//AJ763
        "Ace-High Flush",	//AJ762
        "Ace-High Flush",	//AJ754
        "Ace-High Flush",	//AJ753
        "Ace-High Flush",	//AJ752
        "Ace-High Flush",	//AJ743
        "Ace-High Flush",	//AJ742
        "Ace-High Flush",	//AJ732
        "Ace-High Flush",	//AJ654
        "Ace-High Flush",	//AJ653
        "Ace-High Flush",	//AJ652
        "Ace-High Flush",	//AJ643
        "Ace-High Flush",	//AJ642
        "Ace-High Flush",	//AJ632
        "Ace-High Flush",	//AJ543
        "Ace-High Flush",	//AJ542
        "Ace-High Flush",	//AJ532
        "Ace-High Flush",	//AJ432
        "Ace-High Flush",	//AT987
        "Ace-High Flush",	//AT986
        "Ace-High Flush",	//AT985
        "Ace-High Flush",	//AT984
        "Ace-High Flush",	//AT983
        "Ace-High Flush",	//AT982
        "Ace-High Flush",	//AT976
        "Ace-High Flush",	//AT975
        "Ace-High Flush",	//AT974
        "Ace-High Flush",	//AT973
        "Ace-High Flush",	//AT972
        "Ace-High Flush",	//AT965
        "Ace-High Flush",	//AT964
        "Ace-High Flush",	//AT963
        "Ace-High Flush",	//AT962
        "Ace-High Flush",	//AT954
        "Ace-High Flush",	//AT953
        "Ace-High Flush",	//AT952
        "Ace-High Flush",	//AT943
        "Ace-High Flush",	//AT942
        "Ace-High Flush",	//AT932
        "Ace-High Flush",	//AT876
        "Ace-High Flush",	//AT875
        "Ace-High Flush",	//AT874
        "Ace-High Flush",	//AT873
        "Ace-High Flush",	//AT872
        "Ace-High Flush",	//AT865
        "Ace-High Flush",	//AT864
        "Ace-High Flush",	//AT863
        "Ace-High Flush",	//AT862
        "Ace-High Flush",	//AT854
        "Ace-High Flush",	//AT853
        "Ace-High Flush",	//AT852
        "Ace-High Flush",	//AT843
        "Ace-High Flush",	//AT842
        "Ace-High Flush",	//AT832
        "Ace-High Flush",	//AT765
        "Ace-High Flush",	//AT764
        "Ace-High Flush",	//AT763
        "Ace-High Flush",	//AT762
        "Ace-High Flush",	//AT754
        "Ace-High Flush",	//AT753
        "Ace-High Flush",	//AT752
        "Ace-High Flush",	//AT743
        "Ace-High Flush",	//AT742
        "Ace-High Flush",	//AT732
        "Ace-High Flush",	//AT654
        "Ace-High Flush",	//AT653
        "Ace-High Flush",	//AT652
        "Ace-High Flush",	//AT643
        "Ace-High Flush",	//AT642
        "Ace-High Flush",	//AT632
        "Ace-High Flush",	//AT543
        "Ace-High Flush",	//AT542
        "Ace-High Flush",	//AT532
        "Ace-High Flush",	//AT432
        "Ace-High Flush",	//A9876
        "Ace-High Flush",	//A9875
        "Ace-High Flush",	//A9874
        "Ace-High Flush",	//A9873
        "Ace-High Flush",	//A9872
        "Ace-High Flush",	//A9865
        "Ace-High Flush",	//A9864
        "Ace-High Flush",	//A9863
        "Ace-High Flush",	//A9862
        "Ace-High Flush",	//A9854
        "Ace-High Flush",	//A9853
        "Ace-High Flush",	//A9852
        "Ace-High Flush",	//A9843
        "Ace-High Flush",	//A9842
        "Ace-High Flush",	//A9832
        "Ace-High Flush",	//A9765
        "Ace-High Flush",	//A9764
        "Ace-High Flush",	//A9763
        "Ace-High Flush",	//A9762
        "Ace-High Flush",	//A9754
        "Ace-High Flush",	//A9753
        "Ace-High Flush",	//A9752
        "Ace-High Flush",	//A9743
        "Ace-High Flush",	//A9742
        "Ace-High Flush",	//A9732
        "Ace-High Flush",	//A9654
        "Ace-High Flush",	//A9653
        "Ace-High Flush",	//A9652
        "Ace-High Flush",	//A9643
        "Ace-High Flush",	//A9642
        "Ace-High Flush",	//A9632
        "Ace-High Flush",	//A9543
        "Ace-High Flush",	//A9542
        "Ace-High Flush",	//A9532
        "Ace-High Flush",	//A9432
        "Ace-High Flush",	//A8765
        "Ace-High Flush",	//A8764
        "Ace-High Flush",	//A8763
        "Ace-High Flush",	//A8762
        "Ace-High Flush",	//A8754
        "Ace-High Flush",	//A8753
        "Ace-High Flush",	//A8752
        "Ace-High Flush",	//A8743
        "Ace-High Flush",	//A8742
        "Ace-High Flush",	//A8732
        "Ace-High Flush",	//A8654
        "Ace-High Flush",	//A8653
        "Ace-High Flush",	//A8652
        "Ace-High Flush",	//A8643
        "Ace-High Flush",	//A8642
        "Ace-High Flush",	//A8632
        "Ace-High Flush",	//A8543
        "Ace-High Flush",	//A8542
        "Ace-High Flush",	//A8532
        "Ace-High Flush",	//A8432
        "Ace-High Flush",	//A7654
        "Ace-High Flush",	//A7653
        "Ace-High Flush",	//A7652
        "Ace-High Flush",	//A7643
        "Ace-High Flush",	//A7642
        "Ace-High Flush",	//A7632
        "Ace-High Flush",	//A7543
        "Ace-High Flush",	//A7542
        "Ace-High Flush",	//A7532
        "Ace-High Flush",	//A7432
        "Ace-High Flush",	//A6543
        "Ace-High Flush",	//A6542
        "Ace-High Flush",	//A6532
        "Ace-High Flush",	//A6432
        "King-High Flush",	//KQJT8
        "King-High Flush",	//KQJT7
        "King-High Flush",	//KQJT6
        "King-High Flush",	//KQJT5
        "King-High Flush",	//KQJT4
        "King-High Flush",	//KQJT3
        "King-High Flush",	//KQJT2
        "King-High Flush",	//KQJ98
        "King-High Flush",	//KQJ97
        "King-High Flush",	//KQJ96
        "King-High Flush",	//KQJ95
        "King-High Flush",	//KQJ94
        "King-High Flush",	//KQJ93
        "King-High Flush",	//KQJ92
        "King-High Flush",	//KQJ87
        "King-High Flush",	//KQJ86
        "King-High Flush",	//KQJ85
        "King-High Flush",	//KQJ84
        "King-High Flush",	//KQJ83
        "King-High Flush",	//KQJ82
        "King-High Flush",	//KQJ76
        "King-High Flush",	//KQJ75
        "King-High Flush",	//KQJ74
        "King-High Flush",	//KQJ73
        "King-High Flush",	//KQJ72
        "King-High Flush",	//KQJ65
        "King-High Flush",	//KQJ64
        "King-High Flush",	//KQJ63
        "King-High Flush",	//KQJ62
        "King-High Flush",	//KQJ54
        "King-High Flush",	//KQJ53
        "King-High Flush",	//KQJ52
        "King-High Flush",	//KQJ43
        "King-High Flush",	//KQJ42
        "King-High Flush",	//KQJ32
        "King-High Flush",	//KQT98
        "King-High Flush",	//KQT97
        "King-High Flush",	//KQT96
        "King-High Flush",	//KQT95
        "King-High Flush",	//KQT94
        "King-High Flush",	//KQT93
        "King-High Flush",	//KQT92
        "King-High Flush",	//KQT87
        "King-High Flush",	//KQT86
        "King-High Flush",	//KQT85
        "King-High Flush",	//KQT84
        "King-High Flush",	//KQT83
        "King-High Flush",	//KQT82
        "King-High Flush",	//KQT76
        "King-High Flush",	//KQT75
        "King-High Flush",	//KQT74
        "King-High Flush",	//KQT73
        "King-High Flush",	//KQT72
        "King-High Flush",	//KQT65
        "King-High Flush",	//KQT64
        "King-High Flush",	//KQT63
        "King-High Flush",	//KQT62
        "King-High Flush",	//KQT54
        "King-High Flush",	//KQT53
        "King-High Flush",	//KQT52
        "King-High Flush",	//KQT43
        "King-High Flush",	//KQT42
        "King-High Flush",	//KQT32
        "King-High Flush",	//KQ987
        "King-High Flush",	//KQ986
        "King-High Flush",	//KQ985
        "King-High Flush",	//KQ984
        "King-High Flush",	//KQ983
        "King-High Flush",	//KQ982
        "King-High Flush",	//KQ976
        "King-High Flush",	//KQ975
        "King-High Flush",	//KQ974
        "King-High Flush",	//KQ973
        "King-High Flush",	//KQ972
        "King-High Flush",	//KQ965
        "King-High Flush",	//KQ964
        "King-High Flush",	//KQ963
        "King-High Flush",	//KQ962
        "King-High Flush",	//KQ954
        "King-High Flush",	//KQ953
        "King-High Flush",	//KQ952
        "King-High Flush",	//KQ943
        "King-High Flush",	//KQ942
        "King-High Flush",	//KQ932
        "King-High Flush",	//KQ876
        "King-High Flush",	//KQ875
        "King-High Flush",	//KQ874
        "King-High Flush",	//KQ873
        "King-High Flush",	//KQ872
        "King-High Flush",	//KQ865
        "King-High Flush",	//KQ864
        "King-High Flush",	//KQ863
        "King-High Flush",	//KQ862
        "King-High Flush",	//KQ854
        "King-High Flush",	//KQ853
        "King-High Flush",	//KQ852
        "King-High Flush",	//KQ843
        "King-High Flush",	//KQ842
        "King-High Flush",	//KQ832
        "King-High Flush",	//KQ765
        "King-High Flush",	//KQ764
        "King-High Flush",	//KQ763
        "King-High Flush",	//KQ762
        "King-High Flush",	//KQ754
        "King-High Flush",	//KQ753
        "King-High Flush",	//KQ752
        "King-High Flush",	//KQ743
        "King-High Flush",	//KQ742
        "King-High Flush",	//KQ732
        "King-High Flush",	//KQ654
        "King-High Flush",	//KQ653
        "King-High Flush",	//KQ652
        "King-High Flush",	//KQ643
        "King-High Flush",	//KQ642
        "King-High Flush",	//KQ632
        "King-High Flush",	//KQ543
        "King-High Flush",	//KQ542
        "King-High Flush",	//KQ532
        "King-High Flush",	//KQ432
        "King-High Flush",	//KJT98
        "King-High Flush",	//KJT97
        "King-High Flush",	//KJT96
        "King-High Flush",	//KJT95
        "King-High Flush",	//KJT94
        "King-High Flush",	//KJT93
        "King-High Flush",	//KJT92
        "King-High Flush",	//KJT87
        "King-High Flush",	//KJT86
        "King-High Flush",	//KJT85
        "King-High Flush",	//KJT84
        "King-High Flush",	//KJT83
        "King-High Flush",	//KJT82
        "King-High Flush",	//KJT76
        "King-High Flush",	//KJT75
        "King-High Flush",	//KJT74
        "King-High Flush",	//KJT73
        "King-High Flush",	//KJT72
        "King-High Flush",	//KJT65
        "King-High Flush",	//KJT64
        "King-High Flush",	//KJT63
        "King-High Flush",	//KJT62
        "King-High Flush",	//KJT54
        "King-High Flush",	//KJT53
        "King-High Flush",	//KJT52
        "King-High Flush",	//KJT43
        "King-High Flush",	//KJT42
        "King-High Flush",	//KJT32
        "King-High Flush",	//KJ987
        "King-High Flush",	//KJ986
        "King-High Flush",	//KJ985
        "King-High Flush",	//KJ984
        "King-High Flush",	//KJ983
        "King-High Flush",	//KJ982
        "King-High Flush",	//KJ976
        "King-High Flush",	//KJ975
        "King-High Flush",	//KJ974
        "King-High Flush",	//KJ973
        "King-High Flush",	//KJ972
        "King-High Flush",	//KJ965
        "King-High Flush",	//KJ964
        "King-High Flush",	//KJ963
        "King-High Flush",	//KJ962
        "King-High Flush",	//KJ954
        "King-High Flush",	//KJ953
        "King-High Flush",	//KJ952
        "King-High Flush",	//KJ943
        "King-High Flush",	//KJ942
        "King-High Flush",	//KJ932
        "King-High Flush",	//KJ876
        "King-High Flush",	//KJ875
        "King-High Flush",	//KJ874
        "King-High Flush",	//KJ873
        "King-High Flush",	//KJ872
        "King-High Flush",	//KJ865
        "King-High Flush",	//KJ864
        "King-High Flush",	//KJ863
        "King-High Flush",	//KJ862
        "King-High Flush",	//KJ854
        "King-High Flush",	//KJ853
        "King-High Flush",	//KJ852
        "King-High Flush",	//KJ843
        "King-High Flush",	//KJ842
        "King-High Flush",	//KJ832
        "King-High Flush",	//KJ765
        "King-High Flush",	//KJ764
        "King-High Flush",	//KJ763
        "King-High Flush",	//KJ762
        "King-High Flush",	//KJ754
        "King-High Flush",	//KJ753
        "King-High Flush",	//KJ752
        "King-High Flush",	//KJ743
        "King-High Flush",	//KJ742
        "King-High Flush",	//KJ732
        "King-High Flush",	//KJ654
        "King-High Flush",	//KJ653
        "King-High Flush",	//KJ652
        "King-High Flush",	//KJ643
        "King-High Flush",	//KJ642
        "King-High Flush",	//KJ632
        "King-High Flush",	//KJ543
        "King-High Flush",	//KJ542
        "King-High Flush",	//KJ532
        "King-High Flush",	//KJ432
        "King-High Flush",	//KT987
        "King-High Flush",	//KT986
        "King-High Flush",	//KT985
        "King-High Flush",	//KT984
        "King-High Flush",	//KT983
        "King-High Flush",	//KT982
        "King-High Flush",	//KT976
        "King-High Flush",	//KT975
        "King-High Flush",	//KT974
        "King-High Flush",	//KT973
        "King-High Flush",	//KT972
        "King-High Flush",	//KT965
        "King-High Flush",	//KT964
        "King-High Flush",	//KT963
        "King-High Flush",	//KT962
        "King-High Flush",	//KT954
        "King-High Flush",	//KT953
        "King-High Flush",	//KT952
        "King-High Flush",	//KT943
        "King-High Flush",	//KT942
        "King-High Flush",	//KT932
        "King-High Flush",	//KT876
        "King-High Flush",	//KT875
        "King-High Flush",	//KT874
        "King-High Flush",	//KT873
        "King-High Flush",	//KT872
        "King-High Flush",	//KT865
        "King-High Flush",	//KT864
        "King-High Flush",	//KT863
        "King-High Flush",	//KT862
        "King-High Flush",	//KT854
        "King-High Flush",	//KT853
        "King-High Flush",	//KT852
        "King-High Flush",	//KT843
        "King-High Flush",	//KT842
        "King-High Flush",	//KT832
        "King-High Flush",	//KT765
        "King-High Flush",	//KT764
        "King-High Flush",	//KT763
        "King-High Flush",	//KT762
        "King-High Flush",	//KT754
        "King-High Flush",	//KT753
        "King-High Flush",	//KT752
        "King-High Flush",	//KT743
        "King-High Flush",	//KT742
        "King-High Flush",	//KT732
        "King-High Flush",	//KT654
        "King-High Flush",	//KT653
        "King-High Flush",	//KT652
        "King-High Flush",	//KT643
        "King-High Flush",	//KT642
        "King-High Flush",	//KT632
        "King-High Flush",	//KT543
        "King-High Flush",	//KT542
        "King-High Flush",	//KT532
        "King-High Flush",	//KT432
        "King-High Flush",	//K9876
        "King-High Flush",	//K9875
        "King-High Flush",	//K9874
        "King-High Flush",	//K9873
        "King-High Flush",	//K9872
        "King-High Flush",	//K9865
        "King-High Flush",	//K9864
        "King-High Flush",	//K9863
        "King-High Flush",	//K9862
        "King-High Flush",	//K9854
        "King-High Flush",	//K9853
        "King-High Flush",	//K9852
        "King-High Flush",	//K9843
        "King-High Flush",	//K9842
        "King-High Flush",	//K9832
        "King-High Flush",	//K9765
        "King-High Flush",	//K9764
        "King-High Flush",	//K9763
        "King-High Flush",	//K9762
        "King-High Flush",	//K9754
        "King-High Flush",	//K9753
        "King-High Flush",	//K9752
        "King-High Flush",	//K9743
        "King-High Flush",	//K9742
        "King-High Flush",	//K9732
        "King-High Flush",	//K9654
        "King-High Flush",	//K9653
        "King-High Flush",	//K9652
        "King-High Flush",	//K9643
        "King-High Flush",	//K9642
        "King-High Flush",	//K9632
        "King-High Flush",	//K9543
        "King-High Flush",	//K9542
        "King-High Flush",	//K9532
        "King-High Flush",	//K9432
        "King-High Flush",	//K8765
        "King-High Flush",	//K8764
        "King-High Flush",	//K8763
        "King-High Flush",	//K8762
        "King-High Flush",	//K8754
        "King-High Flush",	//K8753
        "King-High Flush",	//K8752
        "King-High Flush",	//K8743
        "King-High Flush",	//K8742
        "King-High Flush",	//K8732
        "King-High Flush",	//K8654
        "King-High Flush",	//K8653
        "King-High Flush",	//K8652
        "King-High Flush",	//K8643
        "King-High Flush",	//K8642
        "King-High Flush",	//K8632
        "King-High Flush",	//K8543
        "King-High Flush",	//K8542
        "King-High Flush",	//K8532
        "King-High Flush",	//K8432
        "King-High Flush",	//K7654
        "King-High Flush",	//K7653
        "King-High Flush",	//K7652
        "King-High Flush",	//K7643
        "King-High Flush",	//K7642
        "King-High Flush",	//K7632
        "King-High Flush",	//K7543
        "King-High Flush",	//K7542
        "King-High Flush",	//K7532
        "King-High Flush",	//K7432
        "King-High Flush",	//K6543
        "King-High Flush",	//K6542
        "King-High Flush",	//K6532
        "King-High Flush",	//K6432
        "King-High Flush",	//K5432
        "Queen-High Flush",	//QJT97
        "Queen-High Flush",	//QJT96
        "Queen-High Flush",	//QJT95
        "Queen-High Flush",	//QJT94
        "Queen-High Flush",	//QJT93
        "Queen-High Flush",	//QJT92
        "Queen-High Flush",	//QJT87
        "Queen-High Flush",	//QJT86
        "Queen-High Flush",	//QJT85
        "Queen-High Flush",	//QJT84
        "Queen-High Flush",	//QJT83
        "Queen-High Flush",	//QJT82
        "Queen-High Flush",	//QJT76
        "Queen-High Flush",	//QJT75
        "Queen-High Flush",	//QJT74
        "Queen-High Flush",	//QJT73
        "Queen-High Flush",	//QJT72
        "Queen-High Flush",	//QJT65
        "Queen-High Flush",	//QJT64
        "Queen-High Flush",	//QJT63
        "Queen-High Flush",	//QJT62
        "Queen-High Flush",	//QJT54
        "Queen-High Flush",	//QJT53
        "Queen-High Flush",	//QJT52
        "Queen-High Flush",	//QJT43
        "Queen-High Flush",	//QJT42
        "Queen-High Flush",	//QJT32
        "Queen-High Flush",	//QJ987
        "Queen-High Flush",	//QJ986
        "Queen-High Flush",	//QJ985
        "Queen-High Flush",	//QJ984
        "Queen-High Flush",	//QJ983
        "Queen-High Flush",	//QJ982
        "Queen-High Flush",	//QJ976
        "Queen-High Flush",	//QJ975
        "Queen-High Flush",	//QJ974
        "Queen-High Flush",	//QJ973
        "Queen-High Flush",	//QJ972
        "Queen-High Flush",	//QJ965
        "Queen-High Flush",	//QJ964
        "Queen-High Flush",	//QJ963
        "Queen-High Flush",	//QJ962
        "Queen-High Flush",	//QJ954
        "Queen-High Flush",	//QJ953
        "Queen-High Flush",	//QJ952
        "Queen-High Flush",	//QJ943
        "Queen-High Flush",	//QJ942
        "Queen-High Flush",	//QJ932
        "Queen-High Flush",	//QJ876
        "Queen-High Flush",	//QJ875
        "Queen-High Flush",	//QJ874
        "Queen-High Flush",	//QJ873
        "Queen-High Flush",	//QJ872
        "Queen-High Flush",	//QJ865
        "Queen-High Flush",	//QJ864
        "Queen-High Flush",	//QJ863
        "Queen-High Flush",	//QJ862
        "Queen-High Flush",	//QJ854
        "Queen-High Flush",	//QJ853
        "Queen-High Flush",	//QJ852
        "Queen-High Flush",	//QJ843
        "Queen-High Flush",	//QJ842
        "Queen-High Flush",	//QJ832
        "Queen-High Flush",	//QJ765
        "Queen-High Flush",	//QJ764
        "Queen-High Flush",	//QJ763
        "Queen-High Flush",	//QJ762
        "Queen-High Flush",	//QJ754
        "Queen-High Flush",	//QJ753
        "Queen-High Flush",	//QJ752
        "Queen-High Flush",	//QJ743
        "Queen-High Flush",	//QJ742
        "Queen-High Flush",	//QJ732
        "Queen-High Flush",	//QJ654
        "Queen-High Flush",	//QJ653
        "Queen-High Flush",	//QJ652
        "Queen-High Flush",	//QJ643
        "Queen-High Flush",	//QJ642
        "Queen-High Flush",	//QJ632
        "Queen-High Flush",	//QJ543
        "Queen-High Flush",	//QJ542
        "Queen-High Flush",	//QJ532
        "Queen-High Flush",	//QJ432
        "Queen-High Flush",	//QT987
        "Queen-High Flush",	//QT986
        "Queen-High Flush",	//QT985
        "Queen-High Flush",	//QT984
        "Queen-High Flush",	//QT983
        "Queen-High Flush",	//QT982
        "Queen-High Flush",	//QT976
        "Queen-High Flush",	//QT975
        "Queen-High Flush",	//QT974
        "Queen-High Flush",	//QT973
        "Queen-High Flush",	//QT972
        "Queen-High Flush",	//QT965
        "Queen-High Flush",	//QT964
        "Queen-High Flush",	//QT963
        "Queen-High Flush",	//QT962
        "Queen-High Flush",	//QT954
        "Queen-High Flush",	//QT953
        "Queen-High Flush",	//QT952
        "Queen-High Flush",	//QT943
        "Queen-High Flush",	//QT942
        "Queen-High Flush",	//QT932
        "Queen-High Flush",	//QT876
        "Queen-High Flush",	//QT875
        "Queen-High Flush",	//QT874
        "Queen-High Flush",	//QT873
        "Queen-High Flush",	//QT872
        "Queen-High Flush",	//QT865
        "Queen-High Flush",	//QT864
        "Queen-High Flush",	//QT863
        "Queen-High Flush",	//QT862
        "Queen-High Flush",	//QT854
        "Queen-High Flush",	//QT853
        "Queen-High Flush",	//QT852
        "Queen-High Flush",	//QT843
        "Queen-High Flush",	//QT842
        "Queen-High Flush",	//QT832
        "Queen-High Flush",	//QT765
        "Queen-High Flush",	//QT764
        "Queen-High Flush",	//QT763
        "Queen-High Flush",	//QT762
        "Queen-High Flush",	//QT754
        "Queen-High Flush",	//QT753
        "Queen-High Flush",	//QT752
        "Queen-High Flush",	//QT743
        "Queen-High Flush",	//QT742
        "Queen-High Flush",	//QT732
        "Queen-High Flush",	//QT654
        "Queen-High Flush",	//QT653
        "Queen-High Flush",	//QT652
        "Queen-High Flush",	//QT643
        "Queen-High Flush",	//QT642
        "Queen-High Flush",	//QT632
        "Queen-High Flush",	//QT543
        "Queen-High Flush",	//QT542
        "Queen-High Flush",	//QT532
        "Queen-High Flush",	//QT432
        "Queen-High Flush",	//Q9876
        "Queen-High Flush",	//Q9875
        "Queen-High Flush",	//Q9874
        "Queen-High Flush",	//Q9873
        "Queen-High Flush",	//Q9872
        "Queen-High Flush",	//Q9865
        "Queen-High Flush",	//Q9864
        "Queen-High Flush",	//Q9863
        "Queen-High Flush",	//Q9862
        "Queen-High Flush",	//Q9854
        "Queen-High Flush",	//Q9853
        "Queen-High Flush",	//Q9852
        "Queen-High Flush",	//Q9843
        "Queen-High Flush",	//Q9842
        "Queen-High Flush",	//Q9832
        "Queen-High Flush",	//Q9765
        "Queen-High Flush",	//Q9764
        "Queen-High Flush",	//Q9763
        "Queen-High Flush",	//Q9762
        "Queen-High Flush",	//Q9754
        "Queen-High Flush",	//Q9753
        "Queen-High Flush",	//Q9752
        "Queen-High Flush",	//Q9743
        "Queen-High Flush",	//Q9742
        "Queen-High Flush",	//Q9732
        "Queen-High Flush",	//Q9654
        "Queen-High Flush",	//Q9653
        "Queen-High Flush",	//Q9652
        "Queen-High Flush",	//Q9643
        "Queen-High Flush",	//Q9642
        "Queen-High Flush",	//Q9632
        "Queen-High Flush",	//Q9543
        "Queen-High Flush",	//Q9542
        "Queen-High Flush",	//Q9532
        "Queen-High Flush",	//Q9432
        "Queen-High Flush",	//Q8765
        "Queen-High Flush",	//Q8764
        "Queen-High Flush",	//Q8763
        "Queen-High Flush",	//Q8762
        "Queen-High Flush",	//Q8754
        "Queen-High Flush",	//Q8753
        "Queen-High Flush",	//Q8752
        "Queen-High Flush",	//Q8743
        "Queen-High Flush",	//Q8742
        "Queen-High Flush",	//Q8732
        "Queen-High Flush",	//Q8654
        "Queen-High Flush",	//Q8653
        "Queen-High Flush",	//Q8652
        "Queen-High Flush",	//Q8643
        "Queen-High Flush",	//Q8642
        "Queen-High Flush",	//Q8632
        "Queen-High Flush",	//Q8543
        "Queen-High Flush",	//Q8542
        "Queen-High Flush",	//Q8532
        "Queen-High Flush",	//Q8432
        "Queen-High Flush",	//Q7654
        "Queen-High Flush",	//Q7653
        "Queen-High Flush",	//Q7652
        "Queen-High Flush",	//Q7643
        "Queen-High Flush",	//Q7642
        "Queen-High Flush",	//Q7632
        "Queen-High Flush",	//Q7543
        "Queen-High Flush",	//Q7542
        "Queen-High Flush",	//Q7532
        "Queen-High Flush",	//Q7432
        "Queen-High Flush",	//Q6543
        "Queen-High Flush",	//Q6542
        "Queen-High Flush",	//Q6532
        "Queen-High Flush",	//Q6432
        "Queen-High Flush",	//Q5432
        "Jack-High Flush",	//JT986
        "Jack-High Flush",	//JT985
        "Jack-High Flush",	//JT984
        "Jack-High Flush",	//JT983
        "Jack-High Flush",	//JT982
        "Jack-High Flush",	//JT976
        "Jack-High Flush",	//JT975
        "Jack-High Flush",	//JT974
        "Jack-High Flush",	//JT973
        "Jack-High Flush",	//JT972
        "Jack-High Flush",	//JT965
        "Jack-High Flush",	//JT964
        "Jack-High Flush",	//JT963
        "Jack-High Flush",	//JT962
        "Jack-High Flush",	//JT954
        "Jack-High Flush",	//JT953
        "Jack-High Flush",	//JT952
        "Jack-High Flush",	//JT943
        "Jack-High Flush",	//JT942
        "Jack-High Flush",	//JT932
        "Jack-High Flush",	//JT876
        "Jack-High Flush",	//JT875
        "Jack-High Flush",	//JT874
        "Jack-High Flush",	//JT873
        "Jack-High Flush",	//JT872
        "Jack-High Flush",	//JT865
        "Jack-High Flush",	//JT864
        "Jack-High Flush",	//JT863
        "Jack-High Flush",	//JT862
        "Jack-High Flush",	//JT854
        "Jack-High Flush",	//JT853
        "Jack-High Flush",	//JT852
        "Jack-High Flush",	//JT843
        "Jack-High Flush",	//JT842
        "Jack-High Flush",	//JT832
        "Jack-High Flush",	//JT765
        "Jack-High Flush",	//JT764
        "Jack-High Flush",	//JT763
        "Jack-High Flush",	//JT762
        "Jack-High Flush",	//JT754
        "Jack-High Flush",	//JT753
        "Jack-High Flush",	//JT752
        "Jack-High Flush",	//JT743
        "Jack-High Flush",	//JT742
        "Jack-High Flush",	//JT732
        "Jack-High Flush",	//JT654
        "Jack-High Flush",	//JT653
        "Jack-High Flush",	//JT652
        "Jack-High Flush",	//JT643
        "Jack-High Flush",	//JT642
        "Jack-High Flush",	//JT632
        "Jack-High Flush",	//JT543
        "Jack-High Flush",	//JT542
        "Jack-High Flush",	//JT532
        "Jack-High Flush",	//JT432
        "Jack-High Flush",	//J9876
        "Jack-High Flush",	//J9875
        "Jack-High Flush",	//J9874
        "Jack-High Flush",	//J9873
        "Jack-High Flush",	//J9872
        "Jack-High Flush",	//J9865
        "Jack-High Flush",	//J9864
        "Jack-High Flush",	//J9863
        "Jack-High Flush",	//J9862
        "Jack-High Flush",	//J9854
        "Jack-High Flush",	//J9853
        "Jack-High Flush",	//J9852
        "Jack-High Flush",	//J9843
        "Jack-High Flush",	//J9842
        "Jack-High Flush",	//J9832
        "Jack-High Flush",	//J9765
        "Jack-High Flush",	//J9764
        "Jack-High Flush",	//J9763
        "Jack-High Flush",	//J9762
        "Jack-High Flush",	//J9754
        "Jack-High Flush",	//J9753
        "Jack-High Flush",	//J9752
        "Jack-High Flush",	//J9743
        "Jack-High Flush",	//J9742
        "Jack-High Flush",	//J9732
        "Jack-High Flush",	//J9654
        "Jack-High Flush",	//J9653
        "Jack-High Flush",	//J9652
        "Jack-High Flush",	//J9643
        "Jack-High Flush",	//J9642
        "Jack-High Flush",	//J9632
        "Jack-High Flush",	//J9543
        "Jack-High Flush",	//J9542
        "Jack-High Flush",	//J9532
        "Jack-High Flush",	//J9432
        "Jack-High Flush",	//J8765
        "Jack-High Flush",	//J8764
        "Jack-High Flush",	//J8763
        "Jack-High Flush",	//J8762
        "Jack-High Flush",	//J8754
        "Jack-High Flush",	//J8753
        "Jack-High Flush",	//J8752
        "Jack-High Flush",	//J8743
        "Jack-High Flush",	//J8742
        "Jack-High Flush",	//J8732
        "Jack-High Flush",	//J8654
        "Jack-High Flush",	//J8653
        "Jack-High Flush",	//J8652
        "Jack-High Flush",	//J8643
        "Jack-High Flush",	//J8642
        "Jack-High Flush",	//J8632
        "Jack-High Flush",	//J8543
        "Jack-High Flush",	//J8542
        "Jack-High Flush",	//J8532
        "Jack-High Flush",	//J8432
        "Jack-High Flush",	//J7654
        "Jack-High Flush",	//J7653
        "Jack-High Flush",	//J7652
        "Jack-High Flush",	//J7643
        "Jack-High Flush",	//J7642
        "Jack-High Flush",	//J7632
        "Jack-High Flush",	//J7543
        "Jack-High Flush",	//J7542
        "Jack-High Flush",	//J7532
        "Jack-High Flush",	//J7432
        "Jack-High Flush",	//J6543
        "Jack-High Flush",	//J6542
        "Jack-High Flush",	//J6532
        "Jack-High Flush",	//J6432
        "Jack-High Flush",	//J5432
        "Ten-High Flush",	//T9875
        "Ten-High Flush",	//T9874
        "Ten-High Flush",	//T9873
        "Ten-High Flush",	//T9872
        "Ten-High Flush",	//T9865
        "Ten-High Flush",	//T9864
        "Ten-High Flush",	//T9863
        "Ten-High Flush",	//T9862
        "Ten-High Flush",	//T9854
        "Ten-High Flush",	//T9853
        "Ten-High Flush",	//T9852
        "Ten-High Flush",	//T9843
        "Ten-High Flush",	//T9842
        "Ten-High Flush",	//T9832
        "Ten-High Flush",	//T9765
        "Ten-High Flush",	//T9764
        "Ten-High Flush",	//T9763
        "Ten-High Flush",	//T9762
        "Ten-High Flush",	//T9754
        "Ten-High Flush",	//T9753
        "Ten-High Flush",	//T9752
        "Ten-High Flush",	//T9743
        "Ten-High Flush",	//T9742
        "Ten-High Flush",	//T9732
        "Ten-High Flush",	//T9654
        "Ten-High Flush",	//T9653
        "Ten-High Flush",	//T9652
        "Ten-High Flush",	//T9643
        "Ten-High Flush",	//T9642
        "Ten-High Flush",	//T9632
        "Ten-High Flush",	//T9543
        "Ten-High Flush",	//T9542
        "Ten-High Flush",	//T9532
        "Ten-High Flush",	//T9432
        "Ten-High Flush",	//T8765
        "Ten-High Flush",	//T8764
        "Ten-High Flush",	//T8763
        "Ten-High Flush",	//T8762
        "Ten-High Flush",	//T8754
        "Ten-High Flush",	//T8753
        "Ten-High Flush",	//T8752
        "Ten-High Flush",	//T8743
        "Ten-High Flush",	//T8742
        "Ten-High Flush",	//T8732
        "Ten-High Flush",	//T8654
        "Ten-High Flush",	//T8653
        "Ten-High Flush",	//T8652
        "Ten-High Flush",	//T8643
        "Ten-High Flush",	//T8642
        "Ten-High Flush",	//T8632
        "Ten-High Flush",	//T8543
        "Ten-High Flush",	//T8542
        "Ten-High Flush",	//T8532
        "Ten-High Flush",	//T8432
        "Ten-High Flush",	//T7654
        "Ten-High Flush",	//T7653
        "Ten-High Flush",	//T7652
        "Ten-High Flush",	//T7643
        "Ten-High Flush",	//T7642
        "Ten-High Flush",	//T7632
        "Ten-High Flush",	//T7543
        "Ten-High Flush",	//T7542
        "Ten-High Flush",	//T7532
        "Ten-High Flush",	//T7432
        "Ten-High Flush",	//T6543
        "Ten-High Flush",	//T6542
        "Ten-High Flush",	//T6532
        "Ten-High Flush",	//T6432
        "Ten-High Flush",	//T5432
        "Nine-High Flush",	//98764
        "Nine-High Flush",	//98763
        "Nine-High Flush",	//98762
        "Nine-High Flush",	//98754
        "Nine-High Flush",	//98753
        "Nine-High Flush",	//98752
        "Nine-High Flush",	//98743
        "Nine-High Flush",	//98742
        "Nine-High Flush",	//98732
        "Nine-High Flush",	//98654
        "Nine-High Flush",	//98653
        "Nine-High Flush",	//98652
        "Nine-High Flush",	//98643
        "Nine-High Flush",	//98642
        "Nine-High Flush",	//98632
        "Nine-High Flush",	//98543
        "Nine-High Flush",	//98542
        "Nine-High Flush",	//98532
        "Nine-High Flush",	//98432
        "Nine-High Flush",	//97654
        "Nine-High Flush",	//97653
        "Nine-High Flush",	//97652
        "Nine-High Flush",	//97643
        "Nine-High Flush",	//97642
        "Nine-High Flush",	//97632
        "Nine-High Flush",	//97543
        "Nine-High Flush",	//97542
        "Nine-High Flush",	//97532
        "Nine-High Flush",	//97432
        "Nine-High Flush",	//96543
        "Nine-High Flush",	//96542
        "Nine-High Flush",	//96532
        "Nine-High Flush",	//96432
        "Nine-High Flush",	//95432
        "Eight-High Flush",	//87653
        "Eight-High Flush",	//87652
        "Eight-High Flush",	//87643
        "Eight-High Flush",	//87642
        "Eight-High Flush",	//87632
        "Eight-High Flush",	//87543
        "Eight-High Flush",	//87542
        "Eight-High Flush",	//87532
        "Eight-High Flush",	//87432
        "Eight-High Flush",	//86543
        "Eight-High Flush",	//86542
        "Eight-High Flush",	//86532
        "Eight-High Flush",	//86432
        "Eight-High Flush",	//85432
        "Seven-High Flush",	//76542
        "Seven-High Flush",	//76532
        "Seven-High Flush",	//76432
        "Seven-High Flush",	//75432
        "Ace-High Straight",	//AKQJT
        "King-High Straight",	//KQJT9
        "Queen-High Straight",	//QJT98
        "Jack-High Straight",	//JT987
        "Ten-High Straight",	//T9876
        "Nine-High Straight",	//98765
        "Eight-High Straight",	//87654
        "Seven-High Straight",	//76543
        "Six-High Straight",	//65432
        "Five-High Straight",	//5432A
        "Three Aces",	//AAAKQ
        "Three Aces",	//AAAKJ
        "Three Aces",	//AAAKT
        "Three Aces",	//AAAK9
        "Three Aces",	//AAAK8
        "Three Aces",	//AAAK7
        "Three Aces",	//AAAK6
        "Three Aces",	//AAAK5
        "Three Aces",	//AAAK4
        "Three Aces",	//AAAK3
        "Three Aces",	//AAAK2
        "Three Aces",	//AAAQJ
        "Three Aces",	//AAAQT
        "Three Aces",	//AAAQ9
        "Three Aces",	//AAAQ8
        "Three Aces",	//AAAQ7
        "Three Aces",	//AAAQ6
        "Three Aces",	//AAAQ5
        "Three Aces",	//AAAQ4
        "Three Aces",	//AAAQ3
        "Three Aces",	//AAAQ2
        "Three Aces",	//AAAJT
        "Three Aces",	//AAAJ9
        "Three Aces",	//AAAJ8
        "Three Aces",	//AAAJ7
        "Three Aces",	//AAAJ6
        "Three Aces",	//AAAJ5
        "Three Aces",	//AAAJ4
        "Three Aces",	//AAAJ3
        "Three Aces",	//AAAJ2
        "Three Aces",	//AAAT9
        "Three Aces",	//AAAT8
        "Three Aces",	//AAAT7
        "Three Aces",	//AAAT6
        "Three Aces",	//AAAT5
        "Three Aces",	//AAAT4
        "Three Aces",	//AAAT3
        "Three Aces",	//AAAT2
        "Three Aces",	//AAA98
        "Three Aces",	//AAA97
        "Three Aces",	//AAA96
        "Three Aces",	//AAA95
        "Three Aces",	//AAA94
        "Three Aces",	//AAA93
        "Three Aces",	//AAA92
        "Three Aces",	//AAA87
        "Three Aces",	//AAA86
        "Three Aces",	//AAA85
        "Three Aces",	//AAA84
        "Three Aces",	//AAA83
        "Three Aces",	//AAA82
        "Three Aces",	//AAA76
        "Three Aces",	//AAA75
        "Three Aces",	//AAA74
        "Three Aces",	//AAA73
        "Three Aces",	//AAA72
        "Three Aces",	//AAA65
        "Three Aces",	//AAA64
        "Three Aces",	//AAA63
        "Three Aces",	//AAA62
        "Three Aces",	//AAA54
        "Three Aces",	//AAA53
        "Three Aces",	//AAA52
        "Three Aces",	//AAA43
        "Three Aces",	//AAA42
        "Three Aces",	//AAA32
        "Three Kings",	//KKKAQ
        "Three Kings",	//KKKAJ
        "Three Kings",	//KKKAT
        "Three Kings",	//KKKA9
        "Three Kings",	//KKKA8
        "Three Kings",	//KKKA7
        "Three Kings",	//KKKA6
        "Three Kings",	//KKKA5
        "Three Kings",	//KKKA4
        "Three Kings",	//KKKA3
        "Three Kings",	//KKKA2
        "Three Kings",	//KKKQJ
        "Three Kings",	//KKKQT
        "Three Kings",	//KKKQ9
        "Three Kings",	//KKKQ8
        "Three Kings",	//KKKQ7
        "Three Kings",	//KKKQ6
        "Three Kings",	//KKKQ5
        "Three Kings",	//KKKQ4
        "Three Kings",	//KKKQ3
        "Three Kings",	//KKKQ2
        "Three Kings",	//KKKJT
        "Three Kings",	//KKKJ9
        "Three Kings",	//KKKJ8
        "Three Kings",	//KKKJ7
        "Three Kings",	//KKKJ6
        "Three Kings",	//KKKJ5
        "Three Kings",	//KKKJ4
        "Three Kings",	//KKKJ3
        "Three Kings",	//KKKJ2
        "Three Kings",	//KKKT9
        "Three Kings",	//KKKT8
        "Three Kings",	//KKKT7
        "Three Kings",	//KKKT6
        "Three Kings",	//KKKT5
        "Three Kings",	//KKKT4
        "Three Kings",	//KKKT3
        "Three Kings",	//KKKT2
        "Three Kings",	//KKK98
        "Three Kings",	//KKK97
        "Three Kings",	//KKK96
        "Three Kings",	//KKK95
        "Three Kings",	//KKK94
        "Three Kings",	//KKK93
        "Three Kings",	//KKK92
        "Three Kings",	//KKK87
        "Three Kings",	//KKK86
        "Three Kings",	//KKK85
        "Three Kings",	//KKK84
        "Three Kings",	//KKK83
        "Three Kings",	//KKK82
        "Three Kings",	//KKK76
        "Three Kings",	//KKK75
        "Three Kings",	//KKK74
        "Three Kings",	//KKK73
        "Three Kings",	//KKK72
        "Three Kings",	//KKK65
        "Three Kings",	//KKK64
        "Three Kings",	//KKK63
        "Three Kings",	//KKK62
        "Three Kings",	//KKK54
        "Three Kings",	//KKK53
        "Three Kings",	//KKK52
        "Three Kings",	//KKK43
        "Three Kings",	//KKK42
        "Three Kings",	//KKK32
        "Three Queens",	//QQQAK
        "Three Queens",	//QQQAJ
        "Three Queens",	//QQQAT
        "Three Queens",	//QQQA9
        "Three Queens",	//QQQA8
        "Three Queens",	//QQQA7
        "Three Queens",	//QQQA6
        "Three Queens",	//QQQA5
        "Three Queens",	//QQQA4
        "Three Queens",	//QQQA3
        "Three Queens",	//QQQA2
        "Three Queens",	//QQQKJ
        "Three Queens",	//QQQKT
        "Three Queens",	//QQQK9
        "Three Queens",	//QQQK8
        "Three Queens",	//QQQK7
        "Three Queens",	//QQQK6
        "Three Queens",	//QQQK5
        "Three Queens",	//QQQK4
        "Three Queens",	//QQQK3
        "Three Queens",	//QQQK2
        "Three Queens",	//QQQJT
        "Three Queens",	//QQQJ9
        "Three Queens",	//QQQJ8
        "Three Queens",	//QQQJ7
        "Three Queens",	//QQQJ6
        "Three Queens",	//QQQJ5
        "Three Queens",	//QQQJ4
        "Three Queens",	//QQQJ3
        "Three Queens",	//QQQJ2
        "Three Queens",	//QQQT9
        "Three Queens",	//QQQT8
        "Three Queens",	//QQQT7
        "Three Queens",	//QQQT6
        "Three Queens",	//QQQT5
        "Three Queens",	//QQQT4
        "Three Queens",	//QQQT3
        "Three Queens",	//QQQT2
        "Three Queens",	//QQQ98
        "Three Queens",	//QQQ97
        "Three Queens",	//QQQ96
        "Three Queens",	//QQQ95
        "Three Queens",	//QQQ94
        "Three Queens",	//QQQ93
        "Three Queens",	//QQQ92
        "Three Queens",	//QQQ87
        "Three Queens",	//QQQ86
        "Three Queens",	//QQQ85
        "Three Queens",	//QQQ84
        "Three Queens",	//QQQ83
        "Three Queens",	//QQQ82
        "Three Queens",	//QQQ76
        "Three Queens",	//QQQ75
        "Three Queens",	//QQQ74
        "Three Queens",	//QQQ73
        "Three Queens",	//QQQ72
        "Three Queens",	//QQQ65
        "Three Queens",	//QQQ64
        "Three Queens",	//QQQ63
        "Three Queens",	//QQQ62
        "Three Queens",	//QQQ54
        "Three Queens",	//QQQ53
        "Three Queens",	//QQQ52
        "Three Queens",	//QQQ43
        "Three Queens",	//QQQ42
        "Three Queens",	//QQQ32
        "Three Jacks",	//JJJAK
        "Three Jacks",	//JJJAQ
        "Three Jacks",	//JJJAT
        "Three Jacks",	//JJJA9
        "Three Jacks",	//JJJA8
        "Three Jacks",	//JJJA7
        "Three Jacks",	//JJJA6
        "Three Jacks",	//JJJA5
        "Three Jacks",	//JJJA4
        "Three Jacks",	//JJJA3
        "Three Jacks",	//JJJA2
        "Three Jacks",	//JJJKQ
        "Three Jacks",	//JJJKT
        "Three Jacks",	//JJJK9
        "Three Jacks",	//JJJK8
        "Three Jacks",	//JJJK7
        "Three Jacks",	//JJJK6
        "Three Jacks",	//JJJK5
        "Three Jacks",	//JJJK4
        "Three Jacks",	//JJJK3
        "Three Jacks",	//JJJK2
        "Three Jacks",	//JJJQT
        "Three Jacks",	//JJJQ9
        "Three Jacks",	//JJJQ8
        "Three Jacks",	//JJJQ7
        "Three Jacks",	//JJJQ6
        "Three Jacks",	//JJJQ5
        "Three Jacks",	//JJJQ4
        "Three Jacks",	//JJJQ3
        "Three Jacks",	//JJJQ2
        "Three Jacks",	//JJJT9
        "Three Jacks",	//JJJT8
        "Three Jacks",	//JJJT7
        "Three Jacks",	//JJJT6
        "Three Jacks",	//JJJT5
        "Three Jacks",	//JJJT4
        "Three Jacks",	//JJJT3
        "Three Jacks",	//JJJT2
        "Three Jacks",	//JJJ98
        "Three Jacks",	//JJJ97
        "Three Jacks",	//JJJ96
        "Three Jacks",	//JJJ95
        "Three Jacks",	//JJJ94
        "Three Jacks",	//JJJ93
        "Three Jacks",	//JJJ92
        "Three Jacks",	//JJJ87
        "Three Jacks",	//JJJ86
        "Three Jacks",	//JJJ85
        "Three Jacks",	//JJJ84
        "Three Jacks",	//JJJ83
        "Three Jacks",	//JJJ82
        "Three Jacks",	//JJJ76
        "Three Jacks",	//JJJ75
        "Three Jacks",	//JJJ74
        "Three Jacks",	//JJJ73
        "Three Jacks",	//JJJ72
        "Three Jacks",	//JJJ65
        "Three Jacks",	//JJJ64
        "Three Jacks",	//JJJ63
        "Three Jacks",	//JJJ62
        "Three Jacks",	//JJJ54
        "Three Jacks",	//JJJ53
        "Three Jacks",	//JJJ52
        "Three Jacks",	//JJJ43
        "Three Jacks",	//JJJ42
        "Three Jacks",	//JJJ32
        "Three Tens",	//TTTAK
        "Three Tens",	//TTTAQ
        "Three Tens",	//TTTAJ
        "Three Tens",	//TTTA9
        "Three Tens",	//TTTA8
        "Three Tens",	//TTTA7
        "Three Tens",	//TTTA6
        "Three Tens",	//TTTA5
        "Three Tens",	//TTTA4
        "Three Tens",	//TTTA3
        "Three Tens",	//TTTA2
        "Three Tens",	//TTTKQ
        "Three Tens",	//TTTKJ
        "Three Tens",	//TTTK9
        "Three Tens",	//TTTK8
        "Three Tens",	//TTTK7
        "Three Tens",	//TTTK6
        "Three Tens",	//TTTK5
        "Three Tens",	//TTTK4
        "Three Tens",	//TTTK3
        "Three Tens",	//TTTK2
        "Three Tens",	//TTTQJ
        "Three Tens",	//TTTQ9
        "Three Tens",	//TTTQ8
        "Three Tens",	//TTTQ7
        "Three Tens",	//TTTQ6
        "Three Tens",	//TTTQ5
        "Three Tens",	//TTTQ4
        "Three Tens",	//TTTQ3
        "Three Tens",	//TTTQ2
        "Three Tens",	//TTTJ9
        "Three Tens",	//TTTJ8
        "Three Tens",	//TTTJ7
        "Three Tens",	//TTTJ6
        "Three Tens",	//TTTJ5
        "Three Tens",	//TTTJ4
        "Three Tens",	//TTTJ3
        "Three Tens",	//TTTJ2
        "Three Tens",	//TTT98
        "Three Tens",	//TTT97
        "Three Tens",	//TTT96
        "Three Tens",	//TTT95
        "Three Tens",	//TTT94
        "Three Tens",	//TTT93
        "Three Tens",	//TTT92
        "Three Tens",	//TTT87
        "Three Tens",	//TTT86
        "Three Tens",	//TTT85
        "Three Tens",	//TTT84
        "Three Tens",	//TTT83
        "Three Tens",	//TTT82
        "Three Tens",	//TTT76
        "Three Tens",	//TTT75
        "Three Tens",	//TTT74
        "Three Tens",	//TTT73
        "Three Tens",	//TTT72
        "Three Tens",	//TTT65
        "Three Tens",	//TTT64
        "Three Tens",	//TTT63
        "Three Tens",	//TTT62
        "Three Tens",	//TTT54
        "Three Tens",	//TTT53
        "Three Tens",	//TTT52
        "Three Tens",	//TTT43
        "Three Tens",	//TTT42
        "Three Tens",	//TTT32
        "Three Nines",	//999AK
        "Three Nines",	//999AQ
        "Three Nines",	//999AJ
        "Three Nines",	//999AT
        "Three Nines",	//999A8
        "Three Nines",	//999A7
        "Three Nines",	//999A6
        "Three Nines",	//999A5
        "Three Nines",	//999A4
        "Three Nines",	//999A3
        "Three Nines",	//999A2
        "Three Nines",	//999KQ
        "Three Nines",	//999KJ
        "Three Nines",	//999KT
        "Three Nines",	//999K8
        "Three Nines",	//999K7
        "Three Nines",	//999K6
        "Three Nines",	//999K5
        "Three Nines",	//999K4
        "Three Nines",	//999K3
        "Three Nines",	//999K2
        "Three Nines",	//999QJ
        "Three Nines",	//999QT
        "Three Nines",	//999Q8
        "Three Nines",	//999Q7
        "Three Nines",	//999Q6
        "Three Nines",	//999Q5
        "Three Nines",	//999Q4
        "Three Nines",	//999Q3
        "Three Nines",	//999Q2
        "Three Nines",	//999JT
        "Three Nines",	//999J8
        "Three Nines",	//999J7
        "Three Nines",	//999J6
        "Three Nines",	//999J5
        "Three Nines",	//999J4
        "Three Nines",	//999J3
        "Three Nines",	//999J2
        "Three Nines",	//999T8
        "Three Nines",	//999T7
        "Three Nines",	//999T6
        "Three Nines",	//999T5
        "Three Nines",	//999T4
        "Three Nines",	//999T3
        "Three Nines",	//999T2
        "Three Nines",	//99987
        "Three Nines",	//99986
        "Three Nines",	//99985
        "Three Nines",	//99984
        "Three Nines",	//99983
        "Three Nines",	//99982
        "Three Nines",	//99976
        "Three Nines",	//99975
        "Three Nines",	//99974
        "Three Nines",	//99973
        "Three Nines",	//99972
        "Three Nines",	//99965
        "Three Nines",	//99964
        "Three Nines",	//99963
        "Three Nines",	//99962
        "Three Nines",	//99954
        "Three Nines",	//99953
        "Three Nines",	//99952
        "Three Nines",	//99943
        "Three Nines",	//99942
        "Three Nines",	//99932
        "Three Eights",	//888AK
        "Three Eights",	//888AQ
        "Three Eights",	//888AJ
        "Three Eights",	//888AT
        "Three Eights",	//888A9
        "Three Eights",	//888A7
        "Three Eights",	//888A6
        "Three Eights",	//888A5
        "Three Eights",	//888A4
        "Three Eights",	//888A3
        "Three Eights",	//888A2
        "Three Eights",	//888KQ
        "Three Eights",	//888KJ
        "Three Eights",	//888KT
        "Three Eights",	//888K9
        "Three Eights",	//888K7
        "Three Eights",	//888K6
        "Three Eights",	//888K5
        "Three Eights",	//888K4
        "Three Eights",	//888K3
        "Three Eights",	//888K2
        "Three Eights",	//888QJ
        "Three Eights",	//888QT
        "Three Eights",	//888Q9
        "Three Eights",	//888Q7
        "Three Eights",	//888Q6
        "Three Eights",	//888Q5
        "Three Eights",	//888Q4
        "Three Eights",	//888Q3
        "Three Eights",	//888Q2
        "Three Eights",	//888JT
        "Three Eights",	//888J9
        "Three Eights",	//888J7
        "Three Eights",	//888J6
        "Three Eights",	//888J5
        "Three Eights",	//888J4
        "Three Eights",	//888J3
        "Three Eights",	//888J2
        "Three Eights",	//888T9
        "Three Eights",	//888T7
        "Three Eights",	//888T6
        "Three Eights",	//888T5
        "Three Eights",	//888T4
        "Three Eights",	//888T3
        "Three Eights",	//888T2
        "Three Eights",	//88897
        "Three Eights",	//88896
        "Three Eights",	//88895
        "Three Eights",	//88894
        "Three Eights",	//88893
        "Three Eights",	//88892
        "Three Eights",	//88876
        "Three Eights",	//88875
        "Three Eights",	//88874
        "Three Eights",	//88873
        "Three Eights",	//88872
        "Three Eights",	//88865
        "Three Eights",	//88864
        "Three Eights",	//88863
        "Three Eights",	//88862
        "Three Eights",	//88854
        "Three Eights",	//88853
        "Three Eights",	//88852
        "Three Eights",	//88843
        "Three Eights",	//88842
        "Three Eights",	//88832
        "Three Sevens",	//777AK
        "Three Sevens",	//777AQ
        "Three Sevens",	//777AJ
        "Three Sevens",	//777AT
        "Three Sevens",	//777A9
        "Three Sevens",	//777A8
        "Three Sevens",	//777A6
        "Three Sevens",	//777A5
        "Three Sevens",	//777A4
        "Three Sevens",	//777A3
        "Three Sevens",	//777A2
        "Three Sevens",	//777KQ
        "Three Sevens",	//777KJ
        "Three Sevens",	//777KT
        "Three Sevens",	//777K9
        "Three Sevens",	//777K8
        "Three Sevens",	//777K6
        "Three Sevens",	//777K5
        "Three Sevens",	//777K4
        "Three Sevens",	//777K3
        "Three Sevens",	//777K2
        "Three Sevens",	//777QJ
        "Three Sevens",	//777QT
        "Three Sevens",	//777Q9
        "Three Sevens",	//777Q8
        "Three Sevens",	//777Q6
        "Three Sevens",	//777Q5
        "Three Sevens",	//777Q4
        "Three Sevens",	//777Q3
        "Three Sevens",	//777Q2
        "Three Sevens",	//777JT
        "Three Sevens",	//777J9
        "Three Sevens",	//777J8
        "Three Sevens",	//777J6
        "Three Sevens",	//777J5
        "Three Sevens",	//777J4
        "Three Sevens",	//777J3
        "Three Sevens",	//777J2
        "Three Sevens",	//777T9
        "Three Sevens",	//777T8
        "Three Sevens",	//777T6
        "Three Sevens",	//777T5
        "Three Sevens",	//777T4
        "Three Sevens",	//777T3
        "Three Sevens",	//777T2
        "Three Sevens",	//77798
        "Three Sevens",	//77796
        "Three Sevens",	//77795
        "Three Sevens",	//77794
        "Three Sevens",	//77793
        "Three Sevens",	//77792
        "Three Sevens",	//77786
        "Three Sevens",	//77785
        "Three Sevens",	//77784
        "Three Sevens",	//77783
        "Three Sevens",	//77782
        "Three Sevens",	//77765
        "Three Sevens",	//77764
        "Three Sevens",	//77763
        "Three Sevens",	//77762
        "Three Sevens",	//77754
        "Three Sevens",	//77753
        "Three Sevens",	//77752
        "Three Sevens",	//77743
        "Three Sevens",	//77742
        "Three Sevens",	//77732
        "Three Sixes",	//666AK
        "Three Sixes",	//666AQ
        "Three Sixes",	//666AJ
        "Three Sixes",	//666AT
        "Three Sixes",	//666A9
        "Three Sixes",	//666A8
        "Three Sixes",	//666A7
        "Three Sixes",	//666A5
        "Three Sixes",	//666A4
        "Three Sixes",	//666A3
        "Three Sixes",	//666A2
        "Three Sixes",	//666KQ
        "Three Sixes",	//666KJ
        "Three Sixes",	//666KT
        "Three Sixes",	//666K9
        "Three Sixes",	//666K8
        "Three Sixes",	//666K7
        "Three Sixes",	//666K5
        "Three Sixes",	//666K4
        "Three Sixes",	//666K3
        "Three Sixes",	//666K2
        "Three Sixes",	//666QJ
        "Three Sixes",	//666QT
        "Three Sixes",	//666Q9
        "Three Sixes",	//666Q8
        "Three Sixes",	//666Q7
        "Three Sixes",	//666Q5
        "Three Sixes",	//666Q4
        "Three Sixes",	//666Q3
        "Three Sixes",	//666Q2
        "Three Sixes",	//666JT
        "Three Sixes",	//666J9
        "Three Sixes",	//666J8
        "Three Sixes",	//666J7
        "Three Sixes",	//666J5
        "Three Sixes",	//666J4
        "Three Sixes",	//666J3
        "Three Sixes",	//666J2
        "Three Sixes",	//666T9
        "Three Sixes",	//666T8
        "Three Sixes",	//666T7
        "Three Sixes",	//666T5
        "Three Sixes",	//666T4
        "Three Sixes",	//666T3
        "Three Sixes",	//666T2
        "Three Sixes",	//66698
        "Three Sixes",	//66697
        "Three Sixes",	//66695
        "Three Sixes",	//66694
        "Three Sixes",	//66693
        "Three Sixes",	//66692
        "Three Sixes",	//66687
        "Three Sixes",	//66685
        "Three Sixes",	//66684
        "Three Sixes",	//66683
        "Three Sixes",	//66682
        "Three Sixes",	//66675
        "Three Sixes",	//66674
        "Three Sixes",	//66673
        "Three Sixes",	//66672
        "Three Sixes",	//66654
        "Three Sixes",	//66653
        "Three Sixes",	//66652
        "Three Sixes",	//66643
        "Three Sixes",	//66642
        "Three Sixes",	//66632
        "Three Fives",	//555AK
        "Three Fives",	//555AQ
        "Three Fives",	//555AJ
        "Three Fives",	//555AT
        "Three Fives",	//555A9
        "Three Fives",	//555A8
        "Three Fives",	//555A7
        "Three Fives",	//555A6
        "Three Fives",	//555A4
        "Three Fives",	//555A3
        "Three Fives",	//555A2
        "Three Fives",	//555KQ
        "Three Fives",	//555KJ
        "Three Fives",	//555KT
        "Three Fives",	//555K9
        "Three Fives",	//555K8
        "Three Fives",	//555K7
        "Three Fives",	//555K6
        "Three Fives",	//555K4
        "Three Fives",	//555K3
        "Three Fives",	//555K2
        "Three Fives",	//555QJ
        "Three Fives",	//555QT
        "Three Fives",	//555Q9
        "Three Fives",	//555Q8
        "Three Fives",	//555Q7
        "Three Fives",	//555Q6
        "Three Fives",	//555Q4
        "Three Fives",	//555Q3
        "Three Fives",	//555Q2
        "Three Fives",	//555JT
        "Three Fives",	//555J9
        "Three Fives",	//555J8
        "Three Fives",	//555J7
        "Three Fives",	//555J6
        "Three Fives",	//555J4
        "Three Fives",	//555J3
        "Three Fives",	//555J2
        "Three Fives",	//555T9
        "Three Fives",	//555T8
        "Three Fives",	//555T7
        "Three Fives",	//555T6
        "Three Fives",	//555T4
        "Three Fives",	//555T3
        "Three Fives",	//555T2
        "Three Fives",	//55598
        "Three Fives",	//55597
        "Three Fives",	//55596
        "Three Fives",	//55594
        "Three Fives",	//55593
        "Three Fives",	//55592
        "Three Fives",	//55587
        "Three Fives",	//55586
        "Three Fives",	//55584
        "Three Fives",	//55583
        "Three Fives",	//55582
        "Three Fives",	//55576
        "Three Fives",	//55574
        "Three Fives",	//55573
        "Three Fives",	//55572
        "Three Fives",	//55564
        "Three Fives",	//55563
        "Three Fives",	//55562
        "Three Fives",	//55543
        "Three Fives",	//55542
        "Three Fives",	//55532
        "Three Fours",	//444AK
        "Three Fours",	//444AQ
        "Three Fours",	//444AJ
        "Three Fours",	//444AT
        "Three Fours",	//444A9
        "Three Fours",	//444A8
        "Three Fours",	//444A7
        "Three Fours",	//444A6
        "Three Fours",	//444A5
        "Three Fours",	//444A3
        "Three Fours",	//444A2
        "Three Fours",	//444KQ
        "Three Fours",	//444KJ
        "Three Fours",	//444KT
        "Three Fours",	//444K9
        "Three Fours",	//444K8
        "Three Fours",	//444K7
        "Three Fours",	//444K6
        "Three Fours",	//444K5
        "Three Fours",	//444K3
        "Three Fours",	//444K2
        "Three Fours",	//444QJ
        "Three Fours",	//444QT
        "Three Fours",	//444Q9
        "Three Fours",	//444Q8
        "Three Fours",	//444Q7
        "Three Fours",	//444Q6
        "Three Fours",	//444Q5
        "Three Fours",	//444Q3
        "Three Fours",	//444Q2
        "Three Fours",	//444JT
        "Three Fours",	//444J9
        "Three Fours",	//444J8
        "Three Fours",	//444J7
        "Three Fours",	//444J6
        "Three Fours",	//444J5
        "Three Fours",	//444J3
        "Three Fours",	//444J2
        "Three Fours",	//444T9
        "Three Fours",	//444T8
        "Three Fours",	//444T7
        "Three Fours",	//444T6
        "Three Fours",	//444T5
        "Three Fours",	//444T3
        "Three Fours",	//444T2
        "Three Fours",	//44498
        "Three Fours",	//44497
        "Three Fours",	//44496
        "Three Fours",	//44495
        "Three Fours",	//44493
        "Three Fours",	//44492
        "Three Fours",	//44487
        "Three Fours",	//44486
        "Three Fours",	//44485
        "Three Fours",	//44483
        "Three Fours",	//44482
        "Three Fours",	//44476
        "Three Fours",	//44475
        "Three Fours",	//44473
        "Three Fours",	//44472
        "Three Fours",	//44465
        "Three Fours",	//44463
        "Three Fours",	//44462
        "Three Fours",	//44453
        "Three Fours",	//44452
        "Three Fours",	//44432
        "Three Treys",	//333AK
        "Three Treys",	//333AQ
        "Three Treys",	//333AJ
        "Three Treys",	//333AT
        "Three Treys",	//333A9
        "Three Treys",	//333A8
        "Three Treys",	//333A7
        "Three Treys",	//333A6
        "Three Treys",	//333A5
        "Three Treys",	//333A4
        "Three Treys",	//333A2
        "Three Treys",	//333KQ
        "Three Treys",	//333KJ
        "Three Treys",	//333KT
        "Three Treys",	//333K9
        "Three Treys",	//333K8
        "Three Treys",	//333K7
        "Three Treys",	//333K6
        "Three Treys",	//333K5
        "Three Treys",	//333K4
        "Three Treys",	//333K2
        "Three Treys",	//333QJ
        "Three Treys",	//333QT
        "Three Treys",	//333Q9
        "Three Treys",	//333Q8
        "Three Treys",	//333Q7
        "Three Treys",	//333Q6
        "Three Treys",	//333Q5
        "Three Treys",	//333Q4
        "Three Treys",	//333Q2
        "Three Treys",	//333JT
        "Three Treys",	//333J9
        "Three Treys",	//333J8
        "Three Treys",	//333J7
        "Three Treys",	//333J6
        "Three Treys",	//333J5
        "Three Treys",	//333J4
        "Three Treys",	//333J2
        "Three Treys",	//333T9
        "Three Treys",	//333T8
        "Three Treys",	//333T7
        "Three Treys",	//333T6
        "Three Treys",	//333T5
        "Three Treys",	//333T4
        "Three Treys",	//333T2
        "Three Treys",	//33398
        "Three Treys",	//33397
        "Three Treys",	//33396
        "Three Treys",	//33395
        "Three Treys",	//33394
        "Three Treys",	//33392
        "Three Treys",	//33387
        "Three Treys",	//33386
        "Three Treys",	//33385
        "Three Treys",	//33384
        "Three Treys",	//33382
        "Three Treys",	//33376
        "Three Treys",	//33375
        "Three Treys",	//33374
        "Three Treys",	//33372
        "Three Treys",	//33365
        "Three Treys",	//33364
        "Three Treys",	//33362
        "Three Treys",	//33354
        "Three Treys",	//33352
        "Three Treys",	//33342
        "Three Deuces",	//222AK
        "Three Deuces",	//222AQ
        "Three Deuces",	//222AJ
        "Three Deuces",	//222AT
        "Three Deuces",	//222A9
        "Three Deuces",	//222A8
        "Three Deuces",	//222A7
        "Three Deuces",	//222A6
        "Three Deuces",	//222A5
        "Three Deuces",	//222A4
        "Three Deuces",	//222A3
        "Three Deuces",	//222KQ
        "Three Deuces",	//222KJ
        "Three Deuces",	//222KT
        "Three Deuces",	//222K9
        "Three Deuces",	//222K8
        "Three Deuces",	//222K7
        "Three Deuces",	//222K6
        "Three Deuces",	//222K5
        "Three Deuces",	//222K4
        "Three Deuces",	//222K3
        "Three Deuces",	//222QJ
        "Three Deuces",	//222QT
        "Three Deuces",	//222Q9
        "Three Deuces",	//222Q8
        "Three Deuces",	//222Q7
        "Three Deuces",	//222Q6
        "Three Deuces",	//222Q5
        "Three Deuces",	//222Q4
        "Three Deuces",	//222Q3
        "Three Deuces",	//222JT
        "Three Deuces",	//222J9
        "Three Deuces",	//222J8
        "Three Deuces",	//222J7
        "Three Deuces",	//222J6
        "Three Deuces",	//222J5
        "Three Deuces",	//222J4
        "Three Deuces",	//222J3
        "Three Deuces",	//222T9
        "Three Deuces",	//222T8
        "Three Deuces",	//222T7
        "Three Deuces",	//222T6
        "Three Deuces",	//222T5
        "Three Deuces",	//222T4
        "Three Deuces",	//222T3
        "Three Deuces",	//22298
        "Three Deuces",	//22297
        "Three Deuces",	//22296
        "Three Deuces",	//22295
        "Three Deuces",	//22294
        "Three Deuces",	//22293
        "Three Deuces",	//22287
        "Three Deuces",	//22286
        "Three Deuces",	//22285
        "Three Deuces",	//22284
        "Three Deuces",	//22283
        "Three Deuces",	//22276
        "Three Deuces",	//22275
        "Three Deuces",	//22274
        "Three Deuces",	//22273
        "Three Deuces",	//22265
        "Three Deuces",	//22264
        "Three Deuces",	//22263
        "Three Deuces",	//22254
        "Three Deuces",	//22253
        "Three Deuces",	//22243
        "Aces and Kings",	//AAKKQ
        "Aces and Kings",	//AAKKJ
        "Aces and Kings",	//AAKKT
        "Aces and Kings",	//AAKK9
        "Aces and Kings",	//AAKK8
        "Aces and Kings",	//AAKK7
        "Aces and Kings",	//AAKK6
        "Aces and Kings",	//AAKK5
        "Aces and Kings",	//AAKK4
        "Aces and Kings",	//AAKK3
        "Aces and Kings",	//AAKK2
        "Aces and Queens",	//AAQQK
        "Aces and Queens",	//AAQQJ
        "Aces and Queens",	//AAQQT
        "Aces and Queens",	//AAQQ9
        "Aces and Queens",	//AAQQ8
        "Aces and Queens",	//AAQQ7
        "Aces and Queens",	//AAQQ6
        "Aces and Queens",	//AAQQ5
        "Aces and Queens",	//AAQQ4
        "Aces and Queens",	//AAQQ3
        "Aces and Queens",	//AAQQ2
        "Aces and Jacks",	//AAJJK
        "Aces and Jacks",	//AAJJQ
        "Aces and Jacks",	//AAJJT
        "Aces and Jacks",	//AAJJ9
        "Aces and Jacks",	//AAJJ8
        "Aces and Jacks",	//AAJJ7
        "Aces and Jacks",	//AAJJ6
        "Aces and Jacks",	//AAJJ5
        "Aces and Jacks",	//AAJJ4
        "Aces and Jacks",	//AAJJ3
        "Aces and Jacks",	//AAJJ2
        "Aces and Tens",	//AATTK
        "Aces and Tens",	//AATTQ
        "Aces and Tens",	//AATTJ
        "Aces and Tens",	//AATT9
        "Aces and Tens",	//AATT8
        "Aces and Tens",	//AATT7
        "Aces and Tens",	//AATT6
        "Aces and Tens",	//AATT5
        "Aces and Tens",	//AATT4
        "Aces and Tens",	//AATT3
        "Aces and Tens",	//AATT2
        "Aces and Nines",	//AA99K
        "Aces and Nines",	//AA99Q
        "Aces and Nines",	//AA99J
        "Aces and Nines",	//AA99T
        "Aces and Nines",	//AA998
        "Aces and Nines",	//AA997
        "Aces and Nines",	//AA996
        "Aces and Nines",	//AA995
        "Aces and Nines",	//AA994
        "Aces and Nines",	//AA993
        "Aces and Nines",	//AA992
        "Aces and Eights",	//AA88K
        "Aces and Eights",	//AA88Q
        "Aces and Eights",	//AA88J
        "Aces and Eights",	//AA88T
        "Aces and Eights",	//AA889
        "Aces and Eights",	//AA887
        "Aces and Eights",	//AA886
        "Aces and Eights",	//AA885
        "Aces and Eights",	//AA884
        "Aces and Eights",	//AA883
        "Aces and Eights",	//AA882
        "Aces and Sevens",	//AA77K
        "Aces and Sevens",	//AA77Q
        "Aces and Sevens",	//AA77J
        "Aces and Sevens",	//AA77T
        "Aces and Sevens",	//AA779
        "Aces and Sevens",	//AA778
        "Aces and Sevens",	//AA776
        "Aces and Sevens",	//AA775
        "Aces and Sevens",	//AA774
        "Aces and Sevens",	//AA773
        "Aces and Sevens",	//AA772
        "Aces and Sixes",	//AA66K
        "Aces and Sixes",	//AA66Q
        "Aces and Sixes",	//AA66J
        "Aces and Sixes",	//AA66T
        "Aces and Sixes",	//AA669
        "Aces and Sixes",	//AA668
        "Aces and Sixes",	//AA667
        "Aces and Sixes",	//AA665
        "Aces and Sixes",	//AA664
        "Aces and Sixes",	//AA663
        "Aces and Sixes",	//AA662
        "Aces and Fives",	//AA55K
        "Aces and Fives",	//AA55Q
        "Aces and Fives",	//AA55J
        "Aces and Fives",	//AA55T
        "Aces and Fives",	//AA559
        "Aces and Fives",	//AA558
        "Aces and Fives",	//AA557
        "Aces and Fives",	//AA556
        "Aces and Fives",	//AA554
        "Aces and Fives",	//AA553
        "Aces and Fives",	//AA552
        "Aces and Fours",	//AA44K
        "Aces and Fours",	//AA44Q
        "Aces and Fours",	//AA44J
        "Aces and Fours",	//AA44T
        "Aces and Fours",	//AA449
        "Aces and Fours",	//AA448
        "Aces and Fours",	//AA447
        "Aces and Fours",	//AA446
        "Aces and Fours",	//AA445
        "Aces and Fours",	//AA443
        "Aces and Fours",	//AA442
        "Aces and Treys",	//AA33K
        "Aces and Treys",	//AA33Q
        "Aces and Treys",	//AA33J
        "Aces and Treys",	//AA33T
        "Aces and Treys",	//AA339
        "Aces and Treys",	//AA338
        "Aces and Treys",	//AA337
        "Aces and Treys",	//AA336
        "Aces and Treys",	//AA335
        "Aces and Treys",	//AA334
        "Aces and Treys",	//AA332
        "Aces and Deuces",	//AA22K
        "Aces and Deuces",	//AA22Q
        "Aces and Deuces",	//AA22J
        "Aces and Deuces",	//AA22T
        "Aces and Deuces",	//AA229
        "Aces and Deuces",	//AA228
        "Aces and Deuces",	//AA227
        "Aces and Deuces",	//AA226
        "Aces and Deuces",	//AA225
        "Aces and Deuces",	//AA224
        "Aces and Deuces",	//AA223
        "Kings and Queens",	//KKQQA
        "Kings and Queens",	//KKQQJ
        "Kings and Queens",	//KKQQT
        "Kings and Queens",	//KKQQ9
        "Kings and Queens",	//KKQQ8
        "Kings and Queens",	//KKQQ7
        "Kings and Queens",	//KKQQ6
        "Kings and Queens",	//KKQQ5
        "Kings and Queens",	//KKQQ4
        "Kings and Queens",	//KKQQ3
        "Kings and Queens",	//KKQQ2
        "Kings and Jacks",	//KKJJA
        "Kings and Jacks",	//KKJJQ
        "Kings and Jacks",	//KKJJT
        "Kings and Jacks",	//KKJJ9
        "Kings and Jacks",	//KKJJ8
        "Kings and Jacks",	//KKJJ7
        "Kings and Jacks",	//KKJJ6
        "Kings and Jacks",	//KKJJ5
        "Kings and Jacks",	//KKJJ4
        "Kings and Jacks",	//KKJJ3
        "Kings and Jacks",	//KKJJ2
        "Kings and Tens",	//KKTTA
        "Kings and Tens",	//KKTTQ
        "Kings and Tens",	//KKTTJ
        "Kings and Tens",	//KKTT9
        "Kings and Tens",	//KKTT8
        "Kings and Tens",	//KKTT7
        "Kings and Tens",	//KKTT6
        "Kings and Tens",	//KKTT5
        "Kings and Tens",	//KKTT4
        "Kings and Tens",	//KKTT3
        "Kings and Tens",	//KKTT2
        "Kings and Nines",	//KK99A
        "Kings and Nines",	//KK99Q
        "Kings and Nines",	//KK99J
        "Kings and Nines",	//KK99T
        "Kings and Nines",	//KK998
        "Kings and Nines",	//KK997
        "Kings and Nines",	//KK996
        "Kings and Nines",	//KK995
        "Kings and Nines",	//KK994
        "Kings and Nines",	//KK993
        "Kings and Nines",	//KK992
        "Kings and Eights",	//KK88A
        "Kings and Eights",	//KK88Q
        "Kings and Eights",	//KK88J
        "Kings and Eights",	//KK88T
        "Kings and Eights",	//KK889
        "Kings and Eights",	//KK887
        "Kings and Eights",	//KK886
        "Kings and Eights",	//KK885
        "Kings and Eights",	//KK884
        "Kings and Eights",	//KK883
        "Kings and Eights",	//KK882
        "Kings and Sevens",	//KK77A
        "Kings and Sevens",	//KK77Q
        "Kings and Sevens",	//KK77J
        "Kings and Sevens",	//KK77T
        "Kings and Sevens",	//KK779
        "Kings and Sevens",	//KK778
        "Kings and Sevens",	//KK776
        "Kings and Sevens",	//KK775
        "Kings and Sevens",	//KK774
        "Kings and Sevens",	//KK773
        "Kings and Sevens",	//KK772
        "Kings and Sixes",	//KK66A
        "Kings and Sixes",	//KK66Q
        "Kings and Sixes",	//KK66J
        "Kings and Sixes",	//KK66T
        "Kings and Sixes",	//KK669
        "Kings and Sixes",	//KK668
        "Kings and Sixes",	//KK667
        "Kings and Sixes",	//KK665
        "Kings and Sixes",	//KK664
        "Kings and Sixes",	//KK663
        "Kings and Sixes",	//KK662
        "Kings and Fives",	//KK55A
        "Kings and Fives",	//KK55Q
        "Kings and Fives",	//KK55J
        "Kings and Fives",	//KK55T
        "Kings and Fives",	//KK559
        "Kings and Fives",	//KK558
        "Kings and Fives",	//KK557
        "Kings and Fives",	//KK556
        "Kings and Fives",	//KK554
        "Kings and Fives",	//KK553
        "Kings and Fives",	//KK552
        "Kings and Fours",	//KK44A
        "Kings and Fours",	//KK44Q
        "Kings and Fours",	//KK44J
        "Kings and Fours",	//KK44T
        "Kings and Fours",	//KK449
        "Kings and Fours",	//KK448
        "Kings and Fours",	//KK447
        "Kings and Fours",	//KK446
        "Kings and Fours",	//KK445
        "Kings and Fours",	//KK443
        "Kings and Fours",	//KK442
        "Kings and Treys",	//KK33A
        "Kings and Treys",	//KK33Q
        "Kings and Treys",	//KK33J
        "Kings and Treys",	//KK33T
        "Kings and Treys",	//KK339
        "Kings and Treys",	//KK338
        "Kings and Treys",	//KK337
        "Kings and Treys",	//KK336
        "Kings and Treys",	//KK335
        "Kings and Treys",	//KK334
        "Kings and Treys",	//KK332
        "Kings and Deuces",	//KK22A
        "Kings and Deuces",	//KK22Q
        "Kings and Deuces",	//KK22J
        "Kings and Deuces",	//KK22T
        "Kings and Deuces",	//KK229
        "Kings and Deuces",	//KK228
        "Kings and Deuces",	//KK227
        "Kings and Deuces",	//KK226
        "Kings and Deuces",	//KK225
        "Kings and Deuces",	//KK224
        "Kings and Deuces",	//KK223
        "Queens and Jacks",	//QQJJA
        "Queens and Jacks",	//QQJJK
        "Queens and Jacks",	//QQJJT
        "Queens and Jacks",	//QQJJ9
        "Queens and Jacks",	//QQJJ8
        "Queens and Jacks",	//QQJJ7
        "Queens and Jacks",	//QQJJ6
        "Queens and Jacks",	//QQJJ5
        "Queens and Jacks",	//QQJJ4
        "Queens and Jacks",	//QQJJ3
        "Queens and Jacks",	//QQJJ2
        "Queens and Tens",	//QQTTA
        "Queens and Tens",	//QQTTK
        "Queens and Tens",	//QQTTJ
        "Queens and Tens",	//QQTT9
        "Queens and Tens",	//QQTT8
        "Queens and Tens",	//QQTT7
        "Queens and Tens",	//QQTT6
        "Queens and Tens",	//QQTT5
        "Queens and Tens",	//QQTT4
        "Queens and Tens",	//QQTT3
        "Queens and Tens",	//QQTT2
        "Queens and Nines",	//QQ99A
        "Queens and Nines",	//QQ99K
        "Queens and Nines",	//QQ99J
        "Queens and Nines",	//QQ99T
        "Queens and Nines",	//QQ998
        "Queens and Nines",	//QQ997
        "Queens and Nines",	//QQ996
        "Queens and Nines",	//QQ995
        "Queens and Nines",	//QQ994
        "Queens and Nines",	//QQ993
        "Queens and Nines",	//QQ992
        "Queens and Eights",	//QQ88A
        "Queens and Eights",	//QQ88K
        "Queens and Eights",	//QQ88J
        "Queens and Eights",	//QQ88T
        "Queens and Eights",	//QQ889
        "Queens and Eights",	//QQ887
        "Queens and Eights",	//QQ886
        "Queens and Eights",	//QQ885
        "Queens and Eights",	//QQ884
        "Queens and Eights",	//QQ883
        "Queens and Eights",	//QQ882
        "Queens and Sevens",	//QQ77A
        "Queens and Sevens",	//QQ77K
        "Queens and Sevens",	//QQ77J
        "Queens and Sevens",	//QQ77T
        "Queens and Sevens",	//QQ779
        "Queens and Sevens",	//QQ778
        "Queens and Sevens",	//QQ776
        "Queens and Sevens",	//QQ775
        "Queens and Sevens",	//QQ774
        "Queens and Sevens",	//QQ773
        "Queens and Sevens",	//QQ772
        "Queens and Sixes",	//QQ66A
        "Queens and Sixes",	//QQ66K
        "Queens and Sixes",	//QQ66J
        "Queens and Sixes",	//QQ66T
        "Queens and Sixes",	//QQ669
        "Queens and Sixes",	//QQ668
        "Queens and Sixes",	//QQ667
        "Queens and Sixes",	//QQ665
        "Queens and Sixes",	//QQ664
        "Queens and Sixes",	//QQ663
        "Queens and Sixes",	//QQ662
        "Queens and Fives",	//QQ55A
        "Queens and Fives",	//QQ55K
        "Queens and Fives",	//QQ55J
        "Queens and Fives",	//QQ55T
        "Queens and Fives",	//QQ559
        "Queens and Fives",	//QQ558
        "Queens and Fives",	//QQ557
        "Queens and Fives",	//QQ556
        "Queens and Fives",	//QQ554
        "Queens and Fives",	//QQ553
        "Queens and Fives",	//QQ552
        "Queens and Fours",	//QQ44A
        "Queens and Fours",	//QQ44K
        "Queens and Fours",	//QQ44J
        "Queens and Fours",	//QQ44T
        "Queens and Fours",	//QQ449
        "Queens and Fours",	//QQ448
        "Queens and Fours",	//QQ447
        "Queens and Fours",	//QQ446
        "Queens and Fours",	//QQ445
        "Queens and Fours",	//QQ443
        "Queens and Fours",	//QQ442
        "Queens and Treys",	//QQ33A
        "Queens and Treys",	//QQ33K
        "Queens and Treys",	//QQ33J
        "Queens and Treys",	//QQ33T
        "Queens and Treys",	//QQ339
        "Queens and Treys",	//QQ338
        "Queens and Treys",	//QQ337
        "Queens and Treys",	//QQ336
        "Queens and Treys",	//QQ335
        "Queens and Treys",	//QQ334
        "Queens and Treys",	//QQ332
        "Queens and Deuces",	//QQ22A
        "Queens and Deuces",	//QQ22K
        "Queens and Deuces",	//QQ22J
        "Queens and Deuces",	//QQ22T
        "Queens and Deuces",	//QQ229
        "Queens and Deuces",	//QQ228
        "Queens and Deuces",	//QQ227
        "Queens and Deuces",	//QQ226
        "Queens and Deuces",	//QQ225
        "Queens and Deuces",	//QQ224
        "Queens and Deuces",	//QQ223
        "Jacks and Tens",	//JJTTA
        "Jacks and Tens",	//JJTTK
        "Jacks and Tens",	//JJTTQ
        "Jacks and Tens",	//JJTT9
        "Jacks and Tens",	//JJTT8
        "Jacks and Tens",	//JJTT7
        "Jacks and Tens",	//JJTT6
        "Jacks and Tens",	//JJTT5
        "Jacks and Tens",	//JJTT4
        "Jacks and Tens",	//JJTT3
        "Jacks and Tens",	//JJTT2
        "Jacks and Nines",	//JJ99A
        "Jacks and Nines",	//JJ99K
        "Jacks and Nines",	//JJ99Q
        "Jacks and Nines",	//JJ99T
        "Jacks and Nines",	//JJ998
        "Jacks and Nines",	//JJ997
        "Jacks and Nines",	//JJ996
        "Jacks and Nines",	//JJ995
        "Jacks and Nines",	//JJ994
        "Jacks and Nines",	//JJ993
        "Jacks and Nines",	//JJ992
        "Jacks and Eights",	//JJ88A
        "Jacks and Eights",	//JJ88K
        "Jacks and Eights",	//JJ88Q
        "Jacks and Eights",	//JJ88T
        "Jacks and Eights",	//JJ889
        "Jacks and Eights",	//JJ887
        "Jacks and Eights",	//JJ886
        "Jacks and Eights",	//JJ885
        "Jacks and Eights",	//JJ884
        "Jacks and Eights",	//JJ883
        "Jacks and Eights",	//JJ882
        "Jacks and Sevens",	//JJ77A
        "Jacks and Sevens",	//JJ77K
        "Jacks and Sevens",	//JJ77Q
        "Jacks and Sevens",	//JJ77T
        "Jacks and Sevens",	//JJ779
        "Jacks and Sevens",	//JJ778
        "Jacks and Sevens",	//JJ776
        "Jacks and Sevens",	//JJ775
        "Jacks and Sevens",	//JJ774
        "Jacks and Sevens",	//JJ773
        "Jacks and Sevens",	//JJ772
        "Jacks and Sixes",	//JJ66A
        "Jacks and Sixes",	//JJ66K
        "Jacks and Sixes",	//JJ66Q
        "Jacks and Sixes",	//JJ66T
        "Jacks and Sixes",	//JJ669
        "Jacks and Sixes",	//JJ668
        "Jacks and Sixes",	//JJ667
        "Jacks and Sixes",	//JJ665
        "Jacks and Sixes",	//JJ664
        "Jacks and Sixes",	//JJ663
        "Jacks and Sixes",	//JJ662
        "Jacks and Fives",	//JJ55A
        "Jacks and Fives",	//JJ55K
        "Jacks and Fives",	//JJ55Q
        "Jacks and Fives",	//JJ55T
        "Jacks and Fives",	//JJ559
        "Jacks and Fives",	//JJ558
        "Jacks and Fives",	//JJ557
        "Jacks and Fives",	//JJ556
        "Jacks and Fives",	//JJ554
        "Jacks and Fives",	//JJ553
        "Jacks and Fives",	//JJ552
        "Jacks and Fours",	//JJ44A
        "Jacks and Fours",	//JJ44K
        "Jacks and Fours",	//JJ44Q
        "Jacks and Fours",	//JJ44T
        "Jacks and Fours",	//JJ449
        "Jacks and Fours",	//JJ448
        "Jacks and Fours",	//JJ447
        "Jacks and Fours",	//JJ446
        "Jacks and Fours",	//JJ445
        "Jacks and Fours",	//JJ443
        "Jacks and Fours",	//JJ442
        "Jacks and Treys",	//JJ33A
        "Jacks and Treys",	//JJ33K
        "Jacks and Treys",	//JJ33Q
        "Jacks and Treys",	//JJ33T
        "Jacks and Treys",	//JJ339
        "Jacks and Treys",	//JJ338
        "Jacks and Treys",	//JJ337
        "Jacks and Treys",	//JJ336
        "Jacks and Treys",	//JJ335
        "Jacks and Treys",	//JJ334
        "Jacks and Treys",	//JJ332
        "Jacks and Deuces",	//JJ22A
        "Jacks and Deuces",	//JJ22K
        "Jacks and Deuces",	//JJ22Q
        "Jacks and Deuces",	//JJ22T
        "Jacks and Deuces",	//JJ229
        "Jacks and Deuces",	//JJ228
        "Jacks and Deuces",	//JJ227
        "Jacks and Deuces",	//JJ226
        "Jacks and Deuces",	//JJ225
        "Jacks and Deuces",	//JJ224
        "Jacks and Deuces",	//JJ223
        "Tens and Nines",	//TT99A
        "Tens and Nines",	//TT99K
        "Tens and Nines",	//TT99Q
        "Tens and Nines",	//TT99J
        "Tens and Nines",	//TT998
        "Tens and Nines",	//TT997
        "Tens and Nines",	//TT996
        "Tens and Nines",	//TT995
        "Tens and Nines",	//TT994
        "Tens and Nines",	//TT993
        "Tens and Nines",	//TT992
        "Tens and Eights",	//TT88A
        "Tens and Eights",	//TT88K
        "Tens and Eights",	//TT88Q
        "Tens and Eights",	//TT88J
        "Tens and Eights",	//TT889
        "Tens and Eights",	//TT887
        "Tens and Eights",	//TT886
        "Tens and Eights",	//TT885
        "Tens and Eights",	//TT884
        "Tens and Eights",	//TT883
        "Tens and Eights",	//TT882
        "Tens and Sevens",	//TT77A
        "Tens and Sevens",	//TT77K
        "Tens and Sevens",	//TT77Q
        "Tens and Sevens",	//TT77J
        "Tens and Sevens",	//TT779
        "Tens and Sevens",	//TT778
        "Tens and Sevens",	//TT776
        "Tens and Sevens",	//TT775
        "Tens and Sevens",	//TT774
        "Tens and Sevens",	//TT773
        "Tens and Sevens",	//TT772
        "Tens and Sixes",	//TT66A
        "Tens and Sixes",	//TT66K
        "Tens and Sixes",	//TT66Q
        "Tens and Sixes",	//TT66J
        "Tens and Sixes",	//TT669
        "Tens and Sixes",	//TT668
        "Tens and Sixes",	//TT667
        "Tens and Sixes",	//TT665
        "Tens and Sixes",	//TT664
        "Tens and Sixes",	//TT663
        "Tens and Sixes",	//TT662
        "Tens and Fives",	//TT55A
        "Tens and Fives",	//TT55K
        "Tens and Fives",	//TT55Q
        "Tens and Fives",	//TT55J
        "Tens and Fives",	//TT559
        "Tens and Fives",	//TT558
        "Tens and Fives",	//TT557
        "Tens and Fives",	//TT556
        "Tens and Fives",	//TT554
        "Tens and Fives",	//TT553
        "Tens and Fives",	//TT552
        "Tens and Fours",	//TT44A
        "Tens and Fours",	//TT44K
        "Tens and Fours",	//TT44Q
        "Tens and Fours",	//TT44J
        "Tens and Fours",	//TT449
        "Tens and Fours",	//TT448
        "Tens and Fours",	//TT447
        "Tens and Fours",	//TT446
        "Tens and Fours",	//TT445
        "Tens and Fours",	//TT443
        "Tens and Fours",	//TT442
        "Tens and Treys",	//TT33A
        "Tens and Treys",	//TT33K
        "Tens and Treys",	//TT33Q
        "Tens and Treys",	//TT33J
        "Tens and Treys",	//TT339
        "Tens and Treys",	//TT338
        "Tens and Treys",	//TT337
        "Tens and Treys",	//TT336
        "Tens and Treys",	//TT335
        "Tens and Treys",	//TT334
        "Tens and Treys",	//TT332
        "Tens and Deuces",	//TT22A
        "Tens and Deuces",	//TT22K
        "Tens and Deuces",	//TT22Q
        "Tens and Deuces",	//TT22J
        "Tens and Deuces",	//TT229
        "Tens and Deuces",	//TT228
        "Tens and Deuces",	//TT227
        "Tens and Deuces",	//TT226
        "Tens and Deuces",	//TT225
        "Tens and Deuces",	//TT224
        "Tens and Deuces",	//TT223
        "Nines and Eights",	//9988A
        "Nines and Eights",	//9988K
        "Nines and Eights",	//9988Q
        "Nines and Eights",	//9988J
        "Nines and Eights",	//9988T
        "Nines and Eights",	//99887
        "Nines and Eights",	//99886
        "Nines and Eights",	//99885
        "Nines and Eights",	//99884
        "Nines and Eights",	//99883
        "Nines and Eights",	//99882
        "Nines and Sevens",	//9977A
        "Nines and Sevens",	//9977K
        "Nines and Sevens",	//9977Q
        "Nines and Sevens",	//9977J
        "Nines and Sevens",	//9977T
        "Nines and Sevens",	//99778
        "Nines and Sevens",	//99776
        "Nines and Sevens",	//99775
        "Nines and Sevens",	//99774
        "Nines and Sevens",	//99773
        "Nines and Sevens",	//99772
        "Nines and Sixes",	//9966A
        "Nines and Sixes",	//9966K
        "Nines and Sixes",	//9966Q
        "Nines and Sixes",	//9966J
        "Nines and Sixes",	//9966T
        "Nines and Sixes",	//99668
        "Nines and Sixes",	//99667
        "Nines and Sixes",	//99665
        "Nines and Sixes",	//99664
        "Nines and Sixes",	//99663
        "Nines and Sixes",	//99662
        "Nines and Fives",	//9955A
        "Nines and Fives",	//9955K
        "Nines and Fives",	//9955Q
        "Nines and Fives",	//9955J
        "Nines and Fives",	//9955T
        "Nines and Fives",	//99558
        "Nines and Fives",	//99557
        "Nines and Fives",	//99556
        "Nines and Fives",	//99554
        "Nines and Fives",	//99553
        "Nines and Fives",	//99552
        "Nines and Fours",	//9944A
        "Nines and Fours",	//9944K
        "Nines and Fours",	//9944Q
        "Nines and Fours",	//9944J
        "Nines and Fours",	//9944T
        "Nines and Fours",	//99448
        "Nines and Fours",	//99447
        "Nines and Fours",	//99446
        "Nines and Fours",	//99445
        "Nines and Fours",	//99443
        "Nines and Fours",	//99442
        "Nines and Treys",	//9933A
        "Nines and Treys",	//9933K
        "Nines and Treys",	//9933Q
        "Nines and Treys",	//9933J
        "Nines and Treys",	//9933T
        "Nines and Treys",	//99338
        "Nines and Treys",	//99337
        "Nines and Treys",	//99336
        "Nines and Treys",	//99335
        "Nines and Treys",	//99334
        "Nines and Treys",	//99332
        "Nines and Deuces",	//9922A
        "Nines and Deuces",	//9922K
        "Nines and Deuces",	//9922Q
        "Nines and Deuces",	//9922J
        "Nines and Deuces",	//9922T
        "Nines and Deuces",	//99228
        "Nines and Deuces",	//99227
        "Nines and Deuces",	//99226
        "Nines and Deuces",	//99225
        "Nines and Deuces",	//99224
        "Nines and Deuces",	//99223
        "Eights and Sevens",	//8877A
        "Eights and Sevens",	//8877K
        "Eights and Sevens",	//8877Q
        "Eights and Sevens",	//8877J
        "Eights and Sevens",	//8877T
        "Eights and Sevens",	//88779
        "Eights and Sevens",	//88776
        "Eights and Sevens",	//88775
        "Eights and Sevens",	//88774
        "Eights and Sevens",	//88773
        "Eights and Sevens",	//88772
        "Eights and Sixes",	//8866A
        "Eights and Sixes",	//8866K
        "Eights and Sixes",	//8866Q
        "Eights and Sixes",	//8866J
        "Eights and Sixes",	//8866T
        "Eights and Sixes",	//88669
        "Eights and Sixes",	//88667
        "Eights and Sixes",	//88665
        "Eights and Sixes",	//88664
        "Eights and Sixes",	//88663
        "Eights and Sixes",	//88662
        "Eights and Fives",	//8855A
        "Eights and Fives",	//8855K
        "Eights and Fives",	//8855Q
        "Eights and Fives",	//8855J
        "Eights and Fives",	//8855T
        "Eights and Fives",	//88559
        "Eights and Fives",	//88557
        "Eights and Fives",	//88556
        "Eights and Fives",	//88554
        "Eights and Fives",	//88553
        "Eights and Fives",	//88552
        "Eights and Fours",	//8844A
        "Eights and Fours",	//8844K
        "Eights and Fours",	//8844Q
        "Eights and Fours",	//8844J
        "Eights and Fours",	//8844T
        "Eights and Fours",	//88449
        "Eights and Fours",	//88447
        "Eights and Fours",	//88446
        "Eights and Fours",	//88445
        "Eights and Fours",	//88443
        "Eights and Fours",	//88442
        "Eights and Treys",	//8833A
        "Eights and Treys",	//8833K
        "Eights and Treys",	//8833Q
        "Eights and Treys",	//8833J
        "Eights and Treys",	//8833T
        "Eights and Treys",	//88339
        "Eights and Treys",	//88337
        "Eights and Treys",	//88336
        "Eights and Treys",	//88335
        "Eights and Treys",	//88334
        "Eights and Treys",	//88332
        "Eights and Deuces",	//8822A
        "Eights and Deuces",	//8822K
        "Eights and Deuces",	//8822Q
        "Eights and Deuces",	//8822J
        "Eights and Deuces",	//8822T
        "Eights and Deuces",	//88229
        "Eights and Deuces",	//88227
        "Eights and Deuces",	//88226
        "Eights and Deuces",	//88225
        "Eights and Deuces",	//88224
        "Eights and Deuces",	//88223
        "Sevens and Sixes",	//7766A
        "Sevens and Sixes",	//7766K
        "Sevens and Sixes",	//7766Q
        "Sevens and Sixes",	//7766J
        "Sevens and Sixes",	//7766T
        "Sevens and Sixes",	//77669
        "Sevens and Sixes",	//77668
        "Sevens and Sixes",	//77665
        "Sevens and Sixes",	//77664
        "Sevens and Sixes",	//77663
        "Sevens and Sixes",	//77662
        "Sevens and Fives",	//7755A
        "Sevens and Fives",	//7755K
        "Sevens and Fives",	//7755Q
        "Sevens and Fives",	//7755J
        "Sevens and Fives",	//7755T
        "Sevens and Fives",	//77559
        "Sevens and Fives",	//77558
        "Sevens and Fives",	//77556
        "Sevens and Fives",	//77554
        "Sevens and Fives",	//77553
        "Sevens and Fives",	//77552
        "Sevens and Fours",	//7744A
        "Sevens and Fours",	//7744K
        "Sevens and Fours",	//7744Q
        "Sevens and Fours",	//7744J
        "Sevens and Fours",	//7744T
        "Sevens and Fours",	//77449
        "Sevens and Fours",	//77448
        "Sevens and Fours",	//77446
        "Sevens and Fours",	//77445
        "Sevens and Fours",	//77443
        "Sevens and Fours",	//77442
        "Sevens and Treys",	//7733A
        "Sevens and Treys",	//7733K
        "Sevens and Treys",	//7733Q
        "Sevens and Treys",	//7733J
        "Sevens and Treys",	//7733T
        "Sevens and Treys",	//77339
        "Sevens and Treys",	//77338
        "Sevens and Treys",	//77336
        "Sevens and Treys",	//77335
        "Sevens and Treys",	//77334
        "Sevens and Treys",	//77332
        "Sevens and Deuces",	//7722A
        "Sevens and Deuces",	//7722K
        "Sevens and Deuces",	//7722Q
        "Sevens and Deuces",	//7722J
        "Sevens and Deuces",	//7722T
        "Sevens and Deuces",	//77229
        "Sevens and Deuces",	//77228
        "Sevens and Deuces",	//77226
        "Sevens and Deuces",	//77225
        "Sevens and Deuces",	//77224
        "Sevens and Deuces",	//77223
        "Sixes and Fives",	//6655A
        "Sixes and Fives",	//6655K
        "Sixes and Fives",	//6655Q
        "Sixes and Fives",	//6655J
        "Sixes and Fives",	//6655T
        "Sixes and Fives",	//66559
        "Sixes and Fives",	//66558
        "Sixes and Fives",	//66557
        "Sixes and Fives",	//66554
        "Sixes and Fives",	//66553
        "Sixes and Fives",	//66552
        "Sixes and Fours",	//6644A
        "Sixes and Fours",	//6644K
        "Sixes and Fours",	//6644Q
        "Sixes and Fours",	//6644J
        "Sixes and Fours",	//6644T
        "Sixes and Fours",	//66449
        "Sixes and Fours",	//66448
        "Sixes and Fours",	//66447
        "Sixes and Fours",	//66445
        "Sixes and Fours",	//66443
        "Sixes and Fours",	//66442
        "Sixes and Treys",	//6633A
        "Sixes and Treys",	//6633K
        "Sixes and Treys",	//6633Q
        "Sixes and Treys",	//6633J
        "Sixes and Treys",	//6633T
        "Sixes and Treys",	//66339
        "Sixes and Treys",	//66338
        "Sixes and Treys",	//66337
        "Sixes and Treys",	//66335
        "Sixes and Treys",	//66334
        "Sixes and Treys",	//66332
        "Sixes and Deuces",	//6622A
        "Sixes and Deuces",	//6622K
        "Sixes and Deuces",	//6622Q
        "Sixes and Deuces",	//6622J
        "Sixes and Deuces",	//6622T
        "Sixes and Deuces",	//66229
        "Sixes and Deuces",	//66228
        "Sixes and Deuces",	//66227
        "Sixes and Deuces",	//66225
        "Sixes and Deuces",	//66224
        "Sixes and Deuces",	//66223
        "Fives and Fours",	//5544A
        "Fives and Fours",	//5544K
        "Fives and Fours",	//5544Q
        "Fives and Fours",	//5544J
        "Fives and Fours",	//5544T
        "Fives and Fours",	//55449
        "Fives and Fours",	//55448
        "Fives and Fours",	//55447
        "Fives and Fours",	//55446
        "Fives and Fours",	//55443
        "Fives and Fours",	//55442
        "Fives and Treys",	//5533A
        "Fives and Treys",	//5533K
        "Fives and Treys",	//5533Q
        "Fives and Treys",	//5533J
        "Fives and Treys",	//5533T
        "Fives and Treys",	//55339
        "Fives and Treys",	//55338
        "Fives and Treys",	//55337
        "Fives and Treys",	//55336
        "Fives and Treys",	//55334
        "Fives and Treys",	//55332
        "Fives and Deuces",	//5522A
        "Fives and Deuces",	//5522K
        "Fives and Deuces",	//5522Q
        "Fives and Deuces",	//5522J
        "Fives and Deuces",	//5522T
        "Fives and Deuces",	//55229
        "Fives and Deuces",	//55228
        "Fives and Deuces",	//55227
        "Fives and Deuces",	//55226
        "Fives and Deuces",	//55224
        "Fives and Deuces",	//55223
        "Fours and Treys",	//4433A
        "Fours and Treys",	//4433K
        "Fours and Treys",	//4433Q
        "Fours and Treys",	//4433J
        "Fours and Treys",	//4433T
        "Fours and Treys",	//44339
        "Fours and Treys",	//44338
        "Fours and Treys",	//44337
        "Fours and Treys",	//44336
        "Fours and Treys",	//44335
        "Fours and Treys",	//44332
        "Fours and Deuces",	//4422A
        "Fours and Deuces",	//4422K
        "Fours and Deuces",	//4422Q
        "Fours and Deuces",	//4422J
        "Fours and Deuces",	//4422T
        "Fours and Deuces",	//44229
        "Fours and Deuces",	//44228
        "Fours and Deuces",	//44227
        "Fours and Deuces",	//44226
        "Fours and Deuces",	//44225
        "Fours and Deuces",	//44223
        "Treys and Deuces",	//3322A
        "Treys and Deuces",	//3322K
        "Treys and Deuces",	//3322Q
        "Treys and Deuces",	//3322J
        "Treys and Deuces",	//3322T
        "Treys and Deuces",	//33229
        "Treys and Deuces",	//33228
        "Treys and Deuces",	//33227
        "Treys and Deuces",	//33226
        "Treys and Deuces",	//33225
        "Treys and Deuces",	//33224
        "Pair of Aces",	//AAKQJ
        "Pair of Aces",	//AAKQT
        "Pair of Aces",	//AAKQ9
        "Pair of Aces",	//AAKQ8
        "Pair of Aces",	//AAKQ7
        "Pair of Aces",	//AAKQ6
        "Pair of Aces",	//AAKQ5
        "Pair of Aces",	//AAKQ4
        "Pair of Aces",	//AAKQ3
        "Pair of Aces",	//AAKQ2
        "Pair of Aces",	//AAKJT
        "Pair of Aces",	//AAKJ9
        "Pair of Aces",	//AAKJ8
        "Pair of Aces",	//AAKJ7
        "Pair of Aces",	//AAKJ6
        "Pair of Aces",	//AAKJ5
        "Pair of Aces",	//AAKJ4
        "Pair of Aces",	//AAKJ3
        "Pair of Aces",	//AAKJ2
        "Pair of Aces",	//AAKT9
        "Pair of Aces",	//AAKT8
        "Pair of Aces",	//AAKT7
        "Pair of Aces",	//AAKT6
        "Pair of Aces",	//AAKT5
        "Pair of Aces",	//AAKT4
        "Pair of Aces",	//AAKT3
        "Pair of Aces",	//AAKT2
        "Pair of Aces",	//AAK98
        "Pair of Aces",	//AAK97
        "Pair of Aces",	//AAK96
        "Pair of Aces",	//AAK95
        "Pair of Aces",	//AAK94
        "Pair of Aces",	//AAK93
        "Pair of Aces",	//AAK92
        "Pair of Aces",	//AAK87
        "Pair of Aces",	//AAK86
        "Pair of Aces",	//AAK85
        "Pair of Aces",	//AAK84
        "Pair of Aces",	//AAK83
        "Pair of Aces",	//AAK82
        "Pair of Aces",	//AAK76
        "Pair of Aces",	//AAK75
        "Pair of Aces",	//AAK74
        "Pair of Aces",	//AAK73
        "Pair of Aces",	//AAK72
        "Pair of Aces",	//AAK65
        "Pair of Aces",	//AAK64
        "Pair of Aces",	//AAK63
        "Pair of Aces",	//AAK62
        "Pair of Aces",	//AAK54
        "Pair of Aces",	//AAK53
        "Pair of Aces",	//AAK52
        "Pair of Aces",	//AAK43
        "Pair of Aces",	//AAK42
        "Pair of Aces",	//AAK32
        "Pair of Aces",	//AAQJT
        "Pair of Aces",	//AAQJ9
        "Pair of Aces",	//AAQJ8
        "Pair of Aces",	//AAQJ7
        "Pair of Aces",	//AAQJ6
        "Pair of Aces",	//AAQJ5
        "Pair of Aces",	//AAQJ4
        "Pair of Aces",	//AAQJ3
        "Pair of Aces",	//AAQJ2
        "Pair of Aces",	//AAQT9
        "Pair of Aces",	//AAQT8
        "Pair of Aces",	//AAQT7
        "Pair of Aces",	//AAQT6
        "Pair of Aces",	//AAQT5
        "Pair of Aces",	//AAQT4
        "Pair of Aces",	//AAQT3
        "Pair of Aces",	//AAQT2
        "Pair of Aces",	//AAQ98
        "Pair of Aces",	//AAQ97
        "Pair of Aces",	//AAQ96
        "Pair of Aces",	//AAQ95
        "Pair of Aces",	//AAQ94
        "Pair of Aces",	//AAQ93
        "Pair of Aces",	//AAQ92
        "Pair of Aces",	//AAQ87
        "Pair of Aces",	//AAQ86
        "Pair of Aces",	//AAQ85
        "Pair of Aces",	//AAQ84
        "Pair of Aces",	//AAQ83
        "Pair of Aces",	//AAQ82
        "Pair of Aces",	//AAQ76
        "Pair of Aces",	//AAQ75
        "Pair of Aces",	//AAQ74
        "Pair of Aces",	//AAQ73
        "Pair of Aces",	//AAQ72
        "Pair of Aces",	//AAQ65
        "Pair of Aces",	//AAQ64
        "Pair of Aces",	//AAQ63
        "Pair of Aces",	//AAQ62
        "Pair of Aces",	//AAQ54
        "Pair of Aces",	//AAQ53
        "Pair of Aces",	//AAQ52
        "Pair of Aces",	//AAQ43
        "Pair of Aces",	//AAQ42
        "Pair of Aces",	//AAQ32
        "Pair of Aces",	//AAJT9
        "Pair of Aces",	//AAJT8
        "Pair of Aces",	//AAJT7
        "Pair of Aces",	//AAJT6
        "Pair of Aces",	//AAJT5
        "Pair of Aces",	//AAJT4
        "Pair of Aces",	//AAJT3
        "Pair of Aces",	//AAJT2
        "Pair of Aces",	//AAJ98
        "Pair of Aces",	//AAJ97
        "Pair of Aces",	//AAJ96
        "Pair of Aces",	//AAJ95
        "Pair of Aces",	//AAJ94
        "Pair of Aces",	//AAJ93
        "Pair of Aces",	//AAJ92
        "Pair of Aces",	//AAJ87
        "Pair of Aces",	//AAJ86
        "Pair of Aces",	//AAJ85
        "Pair of Aces",	//AAJ84
        "Pair of Aces",	//AAJ83
        "Pair of Aces",	//AAJ82
        "Pair of Aces",	//AAJ76
        "Pair of Aces",	//AAJ75
        "Pair of Aces",	//AAJ74
        "Pair of Aces",	//AAJ73
        "Pair of Aces",	//AAJ72
        "Pair of Aces",	//AAJ65
        "Pair of Aces",	//AAJ64
        "Pair of Aces",	//AAJ63
        "Pair of Aces",	//AAJ62
        "Pair of Aces",	//AAJ54
        "Pair of Aces",	//AAJ53
        "Pair of Aces",	//AAJ52
        "Pair of Aces",	//AAJ43
        "Pair of Aces",	//AAJ42
        "Pair of Aces",	//AAJ32
        "Pair of Aces",	//AAT98
        "Pair of Aces",	//AAT97
        "Pair of Aces",	//AAT96
        "Pair of Aces",	//AAT95
        "Pair of Aces",	//AAT94
        "Pair of Aces",	//AAT93
        "Pair of Aces",	//AAT92
        "Pair of Aces",	//AAT87
        "Pair of Aces",	//AAT86
        "Pair of Aces",	//AAT85
        "Pair of Aces",	//AAT84
        "Pair of Aces",	//AAT83
        "Pair of Aces",	//AAT82
        "Pair of Aces",	//AAT76
        "Pair of Aces",	//AAT75
        "Pair of Aces",	//AAT74
        "Pair of Aces",	//AAT73
        "Pair of Aces",	//AAT72
        "Pair of Aces",	//AAT65
        "Pair of Aces",	//AAT64
        "Pair of Aces",	//AAT63
        "Pair of Aces",	//AAT62
        "Pair of Aces",	//AAT54
        "Pair of Aces",	//AAT53
        "Pair of Aces",	//AAT52
        "Pair of Aces",	//AAT43
        "Pair of Aces",	//AAT42
        "Pair of Aces",	//AAT32
        "Pair of Aces",	//AA987
        "Pair of Aces",	//AA986
        "Pair of Aces",	//AA985
        "Pair of Aces",	//AA984
        "Pair of Aces",	//AA983
        "Pair of Aces",	//AA982
        "Pair of Aces",	//AA976
        "Pair of Aces",	//AA975
        "Pair of Aces",	//AA974
        "Pair of Aces",	//AA973
        "Pair of Aces",	//AA972
        "Pair of Aces",	//AA965
        "Pair of Aces",	//AA964
        "Pair of Aces",	//AA963
        "Pair of Aces",	//AA962
        "Pair of Aces",	//AA954
        "Pair of Aces",	//AA953
        "Pair of Aces",	//AA952
        "Pair of Aces",	//AA943
        "Pair of Aces",	//AA942
        "Pair of Aces",	//AA932
        "Pair of Aces",	//AA876
        "Pair of Aces",	//AA875
        "Pair of Aces",	//AA874
        "Pair of Aces",	//AA873
        "Pair of Aces",	//AA872
        "Pair of Aces",	//AA865
        "Pair of Aces",	//AA864
        "Pair of Aces",	//AA863
        "Pair of Aces",	//AA862
        "Pair of Aces",	//AA854
        "Pair of Aces",	//AA853
        "Pair of Aces",	//AA852
        "Pair of Aces",	//AA843
        "Pair of Aces",	//AA842
        "Pair of Aces",	//AA832
        "Pair of Aces",	//AA765
        "Pair of Aces",	//AA764
        "Pair of Aces",	//AA763
        "Pair of Aces",	//AA762
        "Pair of Aces",	//AA754
        "Pair of Aces",	//AA753
        "Pair of Aces",	//AA752
        "Pair of Aces",	//AA743
        "Pair of Aces",	//AA742
        "Pair of Aces",	//AA732
        "Pair of Aces",	//AA654
        "Pair of Aces",	//AA653
        "Pair of Aces",	//AA652
        "Pair of Aces",	//AA643
        "Pair of Aces",	//AA642
        "Pair of Aces",	//AA632
        "Pair of Aces",	//AA543
        "Pair of Aces",	//AA542
        "Pair of Aces",	//AA532
        "Pair of Aces",	//AA432
        "Pair of Kings",	//KKAQJ
        "Pair of Kings",	//KKAQT
        "Pair of Kings",	//KKAQ9
        "Pair of Kings",	//KKAQ8
        "Pair of Kings",	//KKAQ7
        "Pair of Kings",	//KKAQ6
        "Pair of Kings",	//KKAQ5
        "Pair of Kings",	//KKAQ4
        "Pair of Kings",	//KKAQ3
        "Pair of Kings",	//KKAQ2
        "Pair of Kings",	//KKAJT
        "Pair of Kings",	//KKAJ9
        "Pair of Kings",	//KKAJ8
        "Pair of Kings",	//KKAJ7
        "Pair of Kings",	//KKAJ6
        "Pair of Kings",	//KKAJ5
        "Pair of Kings",	//KKAJ4
        "Pair of Kings",	//KKAJ3
        "Pair of Kings",	//KKAJ2
        "Pair of Kings",	//KKAT9
        "Pair of Kings",	//KKAT8
        "Pair of Kings",	//KKAT7
        "Pair of Kings",	//KKAT6
        "Pair of Kings",	//KKAT5
        "Pair of Kings",	//KKAT4
        "Pair of Kings",	//KKAT3
        "Pair of Kings",	//KKAT2
        "Pair of Kings",	//KKA98
        "Pair of Kings",	//KKA97
        "Pair of Kings",	//KKA96
        "Pair of Kings",	//KKA95
        "Pair of Kings",	//KKA94
        "Pair of Kings",	//KKA93
        "Pair of Kings",	//KKA92
        "Pair of Kings",	//KKA87
        "Pair of Kings",	//KKA86
        "Pair of Kings",	//KKA85
        "Pair of Kings",	//KKA84
        "Pair of Kings",	//KKA83
        "Pair of Kings",	//KKA82
        "Pair of Kings",	//KKA76
        "Pair of Kings",	//KKA75
        "Pair of Kings",	//KKA74
        "Pair of Kings",	//KKA73
        "Pair of Kings",	//KKA72
        "Pair of Kings",	//KKA65
        "Pair of Kings",	//KKA64
        "Pair of Kings",	//KKA63
        "Pair of Kings",	//KKA62
        "Pair of Kings",	//KKA54
        "Pair of Kings",	//KKA53
        "Pair of Kings",	//KKA52
        "Pair of Kings",	//KKA43
        "Pair of Kings",	//KKA42
        "Pair of Kings",	//KKA32
        "Pair of Kings",	//KKQJT
        "Pair of Kings",	//KKQJ9
        "Pair of Kings",	//KKQJ8
        "Pair of Kings",	//KKQJ7
        "Pair of Kings",	//KKQJ6
        "Pair of Kings",	//KKQJ5
        "Pair of Kings",	//KKQJ4
        "Pair of Kings",	//KKQJ3
        "Pair of Kings",	//KKQJ2
        "Pair of Kings",	//KKQT9
        "Pair of Kings",	//KKQT8
        "Pair of Kings",	//KKQT7
        "Pair of Kings",	//KKQT6
        "Pair of Kings",	//KKQT5
        "Pair of Kings",	//KKQT4
        "Pair of Kings",	//KKQT3
        "Pair of Kings",	//KKQT2
        "Pair of Kings",	//KKQ98
        "Pair of Kings",	//KKQ97
        "Pair of Kings",	//KKQ96
        "Pair of Kings",	//KKQ95
        "Pair of Kings",	//KKQ94
        "Pair of Kings",	//KKQ93
        "Pair of Kings",	//KKQ92
        "Pair of Kings",	//KKQ87
        "Pair of Kings",	//KKQ86
        "Pair of Kings",	//KKQ85
        "Pair of Kings",	//KKQ84
        "Pair of Kings",	//KKQ83
        "Pair of Kings",	//KKQ82
        "Pair of Kings",	//KKQ76
        "Pair of Kings",	//KKQ75
        "Pair of Kings",	//KKQ74
        "Pair of Kings",	//KKQ73
        "Pair of Kings",	//KKQ72
        "Pair of Kings",	//KKQ65
        "Pair of Kings",	//KKQ64
        "Pair of Kings",	//KKQ63
        "Pair of Kings",	//KKQ62
        "Pair of Kings",	//KKQ54
        "Pair of Kings",	//KKQ53
        "Pair of Kings",	//KKQ52
        "Pair of Kings",	//KKQ43
        "Pair of Kings",	//KKQ42
        "Pair of Kings",	//KKQ32
        "Pair of Kings",	//KKJT9
        "Pair of Kings",	//KKJT8
        "Pair of Kings",	//KKJT7
        "Pair of Kings",	//KKJT6
        "Pair of Kings",	//KKJT5
        "Pair of Kings",	//KKJT4
        "Pair of Kings",	//KKJT3
        "Pair of Kings",	//KKJT2
        "Pair of Kings",	//KKJ98
        "Pair of Kings",	//KKJ97
        "Pair of Kings",	//KKJ96
        "Pair of Kings",	//KKJ95
        "Pair of Kings",	//KKJ94
        "Pair of Kings",	//KKJ93
        "Pair of Kings",	//KKJ92
        "Pair of Kings",	//KKJ87
        "Pair of Kings",	//KKJ86
        "Pair of Kings",	//KKJ85
        "Pair of Kings",	//KKJ84
        "Pair of Kings",	//KKJ83
        "Pair of Kings",	//KKJ82
        "Pair of Kings",	//KKJ76
        "Pair of Kings",	//KKJ75
        "Pair of Kings",	//KKJ74
        "Pair of Kings",	//KKJ73
        "Pair of Kings",	//KKJ72
        "Pair of Kings",	//KKJ65
        "Pair of Kings",	//KKJ64
        "Pair of Kings",	//KKJ63
        "Pair of Kings",	//KKJ62
        "Pair of Kings",	//KKJ54
        "Pair of Kings",	//KKJ53
        "Pair of Kings",	//KKJ52
        "Pair of Kings",	//KKJ43
        "Pair of Kings",	//KKJ42
        "Pair of Kings",	//KKJ32
        "Pair of Kings",	//KKT98
        "Pair of Kings",	//KKT97
        "Pair of Kings",	//KKT96
        "Pair of Kings",	//KKT95
        "Pair of Kings",	//KKT94
        "Pair of Kings",	//KKT93
        "Pair of Kings",	//KKT92
        "Pair of Kings",	//KKT87
        "Pair of Kings",	//KKT86
        "Pair of Kings",	//KKT85
        "Pair of Kings",	//KKT84
        "Pair of Kings",	//KKT83
        "Pair of Kings",	//KKT82
        "Pair of Kings",	//KKT76
        "Pair of Kings",	//KKT75
        "Pair of Kings",	//KKT74
        "Pair of Kings",	//KKT73
        "Pair of Kings",	//KKT72
        "Pair of Kings",	//KKT65
        "Pair of Kings",	//KKT64
        "Pair of Kings",	//KKT63
        "Pair of Kings",	//KKT62
        "Pair of Kings",	//KKT54
        "Pair of Kings",	//KKT53
        "Pair of Kings",	//KKT52
        "Pair of Kings",	//KKT43
        "Pair of Kings",	//KKT42
        "Pair of Kings",	//KKT32
        "Pair of Kings",	//KK987
        "Pair of Kings",	//KK986
        "Pair of Kings",	//KK985
        "Pair of Kings",	//KK984
        "Pair of Kings",	//KK983
        "Pair of Kings",	//KK982
        "Pair of Kings",	//KK976
        "Pair of Kings",	//KK975
        "Pair of Kings",	//KK974
        "Pair of Kings",	//KK973
        "Pair of Kings",	//KK972
        "Pair of Kings",	//KK965
        "Pair of Kings",	//KK964
        "Pair of Kings",	//KK963
        "Pair of Kings",	//KK962
        "Pair of Kings",	//KK954
        "Pair of Kings",	//KK953
        "Pair of Kings",	//KK952
        "Pair of Kings",	//KK943
        "Pair of Kings",	//KK942
        "Pair of Kings",	//KK932
        "Pair of Kings",	//KK876
        "Pair of Kings",	//KK875
        "Pair of Kings",	//KK874
        "Pair of Kings",	//KK873
        "Pair of Kings",	//KK872
        "Pair of Kings",	//KK865
        "Pair of Kings",	//KK864
        "Pair of Kings",	//KK863
        "Pair of Kings",	//KK862
        "Pair of Kings",	//KK854
        "Pair of Kings",	//KK853
        "Pair of Kings",	//KK852
        "Pair of Kings",	//KK843
        "Pair of Kings",	//KK842
        "Pair of Kings",	//KK832
        "Pair of Kings",	//KK765
        "Pair of Kings",	//KK764
        "Pair of Kings",	//KK763
        "Pair of Kings",	//KK762
        "Pair of Kings",	//KK754
        "Pair of Kings",	//KK753
        "Pair of Kings",	//KK752
        "Pair of Kings",	//KK743
        "Pair of Kings",	//KK742
        "Pair of Kings",	//KK732
        "Pair of Kings",	//KK654
        "Pair of Kings",	//KK653
        "Pair of Kings",	//KK652
        "Pair of Kings",	//KK643
        "Pair of Kings",	//KK642
        "Pair of Kings",	//KK632
        "Pair of Kings",	//KK543
        "Pair of Kings",	//KK542
        "Pair of Kings",	//KK532
        "Pair of Kings",	//KK432
        "Pair of Queens",	//QQAKJ
        "Pair of Queens",	//QQAKT
        "Pair of Queens",	//QQAK9
        "Pair of Queens",	//QQAK8
        "Pair of Queens",	//QQAK7
        "Pair of Queens",	//QQAK6
        "Pair of Queens",	//QQAK5
        "Pair of Queens",	//QQAK4
        "Pair of Queens",	//QQAK3
        "Pair of Queens",	//QQAK2
        "Pair of Queens",	//QQAJT
        "Pair of Queens",	//QQAJ9
        "Pair of Queens",	//QQAJ8
        "Pair of Queens",	//QQAJ7
        "Pair of Queens",	//QQAJ6
        "Pair of Queens",	//QQAJ5
        "Pair of Queens",	//QQAJ4
        "Pair of Queens",	//QQAJ3
        "Pair of Queens",	//QQAJ2
        "Pair of Queens",	//QQAT9
        "Pair of Queens",	//QQAT8
        "Pair of Queens",	//QQAT7
        "Pair of Queens",	//QQAT6
        "Pair of Queens",	//QQAT5
        "Pair of Queens",	//QQAT4
        "Pair of Queens",	//QQAT3
        "Pair of Queens",	//QQAT2
        "Pair of Queens",	//QQA98
        "Pair of Queens",	//QQA97
        "Pair of Queens",	//QQA96
        "Pair of Queens",	//QQA95
        "Pair of Queens",	//QQA94
        "Pair of Queens",	//QQA93
        "Pair of Queens",	//QQA92
        "Pair of Queens",	//QQA87
        "Pair of Queens",	//QQA86
        "Pair of Queens",	//QQA85
        "Pair of Queens",	//QQA84
        "Pair of Queens",	//QQA83
        "Pair of Queens",	//QQA82
        "Pair of Queens",	//QQA76
        "Pair of Queens",	//QQA75
        "Pair of Queens",	//QQA74
        "Pair of Queens",	//QQA73
        "Pair of Queens",	//QQA72
        "Pair of Queens",	//QQA65
        "Pair of Queens",	//QQA64
        "Pair of Queens",	//QQA63
        "Pair of Queens",	//QQA62
        "Pair of Queens",	//QQA54
        "Pair of Queens",	//QQA53
        "Pair of Queens",	//QQA52
        "Pair of Queens",	//QQA43
        "Pair of Queens",	//QQA42
        "Pair of Queens",	//QQA32
        "Pair of Queens",	//QQKJT
        "Pair of Queens",	//QQKJ9
        "Pair of Queens",	//QQKJ8
        "Pair of Queens",	//QQKJ7
        "Pair of Queens",	//QQKJ6
        "Pair of Queens",	//QQKJ5
        "Pair of Queens",	//QQKJ4
        "Pair of Queens",	//QQKJ3
        "Pair of Queens",	//QQKJ2
        "Pair of Queens",	//QQKT9
        "Pair of Queens",	//QQKT8
        "Pair of Queens",	//QQKT7
        "Pair of Queens",	//QQKT6
        "Pair of Queens",	//QQKT5
        "Pair of Queens",	//QQKT4
        "Pair of Queens",	//QQKT3
        "Pair of Queens",	//QQKT2
        "Pair of Queens",	//QQK98
        "Pair of Queens",	//QQK97
        "Pair of Queens",	//QQK96
        "Pair of Queens",	//QQK95
        "Pair of Queens",	//QQK94
        "Pair of Queens",	//QQK93
        "Pair of Queens",	//QQK92
        "Pair of Queens",	//QQK87
        "Pair of Queens",	//QQK86
        "Pair of Queens",	//QQK85
        "Pair of Queens",	//QQK84
        "Pair of Queens",	//QQK83
        "Pair of Queens",	//QQK82
        "Pair of Queens",	//QQK76
        "Pair of Queens",	//QQK75
        "Pair of Queens",	//QQK74
        "Pair of Queens",	//QQK73
        "Pair of Queens",	//QQK72
        "Pair of Queens",	//QQK65
        "Pair of Queens",	//QQK64
        "Pair of Queens",	//QQK63
        "Pair of Queens",	//QQK62
        "Pair of Queens",	//QQK54
        "Pair of Queens",	//QQK53
        "Pair of Queens",	//QQK52
        "Pair of Queens",	//QQK43
        "Pair of Queens",	//QQK42
        "Pair of Queens",	//QQK32
        "Pair of Queens",	//QQJT9
        "Pair of Queens",	//QQJT8
        "Pair of Queens",	//QQJT7
        "Pair of Queens",	//QQJT6
        "Pair of Queens",	//QQJT5
        "Pair of Queens",	//QQJT4
        "Pair of Queens",	//QQJT3
        "Pair of Queens",	//QQJT2
        "Pair of Queens",	//QQJ98
        "Pair of Queens",	//QQJ97
        "Pair of Queens",	//QQJ96
        "Pair of Queens",	//QQJ95
        "Pair of Queens",	//QQJ94
        "Pair of Queens",	//QQJ93
        "Pair of Queens",	//QQJ92
        "Pair of Queens",	//QQJ87
        "Pair of Queens",	//QQJ86
        "Pair of Queens",	//QQJ85
        "Pair of Queens",	//QQJ84
        "Pair of Queens",	//QQJ83
        "Pair of Queens",	//QQJ82
        "Pair of Queens",	//QQJ76
        "Pair of Queens",	//QQJ75
        "Pair of Queens",	//QQJ74
        "Pair of Queens",	//QQJ73
        "Pair of Queens",	//QQJ72
        "Pair of Queens",	//QQJ65
        "Pair of Queens",	//QQJ64
        "Pair of Queens",	//QQJ63
        "Pair of Queens",	//QQJ62
        "Pair of Queens",	//QQJ54
        "Pair of Queens",	//QQJ53
        "Pair of Queens",	//QQJ52
        "Pair of Queens",	//QQJ43
        "Pair of Queens",	//QQJ42
        "Pair of Queens",	//QQJ32
        "Pair of Queens",	//QQT98
        "Pair of Queens",	//QQT97
        "Pair of Queens",	//QQT96
        "Pair of Queens",	//QQT95
        "Pair of Queens",	//QQT94
        "Pair of Queens",	//QQT93
        "Pair of Queens",	//QQT92
        "Pair of Queens",	//QQT87
        "Pair of Queens",	//QQT86
        "Pair of Queens",	//QQT85
        "Pair of Queens",	//QQT84
        "Pair of Queens",	//QQT83
        "Pair of Queens",	//QQT82
        "Pair of Queens",	//QQT76
        "Pair of Queens",	//QQT75
        "Pair of Queens",	//QQT74
        "Pair of Queens",	//QQT73
        "Pair of Queens",	//QQT72
        "Pair of Queens",	//QQT65
        "Pair of Queens",	//QQT64
        "Pair of Queens",	//QQT63
        "Pair of Queens",	//QQT62
        "Pair of Queens",	//QQT54
        "Pair of Queens",	//QQT53
        "Pair of Queens",	//QQT52
        "Pair of Queens",	//QQT43
        "Pair of Queens",	//QQT42
        "Pair of Queens",	//QQT32
        "Pair of Queens",	//QQ987
        "Pair of Queens",	//QQ986
        "Pair of Queens",	//QQ985
        "Pair of Queens",	//QQ984
        "Pair of Queens",	//QQ983
        "Pair of Queens",	//QQ982
        "Pair of Queens",	//QQ976
        "Pair of Queens",	//QQ975
        "Pair of Queens",	//QQ974
        "Pair of Queens",	//QQ973
        "Pair of Queens",	//QQ972
        "Pair of Queens",	//QQ965
        "Pair of Queens",	//QQ964
        "Pair of Queens",	//QQ963
        "Pair of Queens",	//QQ962
        "Pair of Queens",	//QQ954
        "Pair of Queens",	//QQ953
        "Pair of Queens",	//QQ952
        "Pair of Queens",	//QQ943
        "Pair of Queens",	//QQ942
        "Pair of Queens",	//QQ932
        "Pair of Queens",	//QQ876
        "Pair of Queens",	//QQ875
        "Pair of Queens",	//QQ874
        "Pair of Queens",	//QQ873
        "Pair of Queens",	//QQ872
        "Pair of Queens",	//QQ865
        "Pair of Queens",	//QQ864
        "Pair of Queens",	//QQ863
        "Pair of Queens",	//QQ862
        "Pair of Queens",	//QQ854
        "Pair of Queens",	//QQ853
        "Pair of Queens",	//QQ852
        "Pair of Queens",	//QQ843
        "Pair of Queens",	//QQ842
        "Pair of Queens",	//QQ832
        "Pair of Queens",	//QQ765
        "Pair of Queens",	//QQ764
        "Pair of Queens",	//QQ763
        "Pair of Queens",	//QQ762
        "Pair of Queens",	//QQ754
        "Pair of Queens",	//QQ753
        "Pair of Queens",	//QQ752
        "Pair of Queens",	//QQ743
        "Pair of Queens",	//QQ742
        "Pair of Queens",	//QQ732
        "Pair of Queens",	//QQ654
        "Pair of Queens",	//QQ653
        "Pair of Queens",	//QQ652
        "Pair of Queens",	//QQ643
        "Pair of Queens",	//QQ642
        "Pair of Queens",	//QQ632
        "Pair of Queens",	//QQ543
        "Pair of Queens",	//QQ542
        "Pair of Queens",	//QQ532
        "Pair of Queens",	//QQ432
        "Pair of Jacks",	//JJAKQ
        "Pair of Jacks",	//JJAKT
        "Pair of Jacks",	//JJAK9
        "Pair of Jacks",	//JJAK8
        "Pair of Jacks",	//JJAK7
        "Pair of Jacks",	//JJAK6
        "Pair of Jacks",	//JJAK5
        "Pair of Jacks",	//JJAK4
        "Pair of Jacks",	//JJAK3
        "Pair of Jacks",	//JJAK2
        "Pair of Jacks",	//JJAQT
        "Pair of Jacks",	//JJAQ9
        "Pair of Jacks",	//JJAQ8
        "Pair of Jacks",	//JJAQ7
        "Pair of Jacks",	//JJAQ6
        "Pair of Jacks",	//JJAQ5
        "Pair of Jacks",	//JJAQ4
        "Pair of Jacks",	//JJAQ3
        "Pair of Jacks",	//JJAQ2
        "Pair of Jacks",	//JJAT9
        "Pair of Jacks",	//JJAT8
        "Pair of Jacks",	//JJAT7
        "Pair of Jacks",	//JJAT6
        "Pair of Jacks",	//JJAT5
        "Pair of Jacks",	//JJAT4
        "Pair of Jacks",	//JJAT3
        "Pair of Jacks",	//JJAT2
        "Pair of Jacks",	//JJA98
        "Pair of Jacks",	//JJA97
        "Pair of Jacks",	//JJA96
        "Pair of Jacks",	//JJA95
        "Pair of Jacks",	//JJA94
        "Pair of Jacks",	//JJA93
        "Pair of Jacks",	//JJA92
        "Pair of Jacks",	//JJA87
        "Pair of Jacks",	//JJA86
        "Pair of Jacks",	//JJA85
        "Pair of Jacks",	//JJA84
        "Pair of Jacks",	//JJA83
        "Pair of Jacks",	//JJA82
        "Pair of Jacks",	//JJA76
        "Pair of Jacks",	//JJA75
        "Pair of Jacks",	//JJA74
        "Pair of Jacks",	//JJA73
        "Pair of Jacks",	//JJA72
        "Pair of Jacks",	//JJA65
        "Pair of Jacks",	//JJA64
        "Pair of Jacks",	//JJA63
        "Pair of Jacks",	//JJA62
        "Pair of Jacks",	//JJA54
        "Pair of Jacks",	//JJA53
        "Pair of Jacks",	//JJA52
        "Pair of Jacks",	//JJA43
        "Pair of Jacks",	//JJA42
        "Pair of Jacks",	//JJA32
        "Pair of Jacks",	//JJKQT
        "Pair of Jacks",	//JJKQ9
        "Pair of Jacks",	//JJKQ8
        "Pair of Jacks",	//JJKQ7
        "Pair of Jacks",	//JJKQ6
        "Pair of Jacks",	//JJKQ5
        "Pair of Jacks",	//JJKQ4
        "Pair of Jacks",	//JJKQ3
        "Pair of Jacks",	//JJKQ2
        "Pair of Jacks",	//JJKT9
        "Pair of Jacks",	//JJKT8
        "Pair of Jacks",	//JJKT7
        "Pair of Jacks",	//JJKT6
        "Pair of Jacks",	//JJKT5
        "Pair of Jacks",	//JJKT4
        "Pair of Jacks",	//JJKT3
        "Pair of Jacks",	//JJKT2
        "Pair of Jacks",	//JJK98
        "Pair of Jacks",	//JJK97
        "Pair of Jacks",	//JJK96
        "Pair of Jacks",	//JJK95
        "Pair of Jacks",	//JJK94
        "Pair of Jacks",	//JJK93
        "Pair of Jacks",	//JJK92
        "Pair of Jacks",	//JJK87
        "Pair of Jacks",	//JJK86
        "Pair of Jacks",	//JJK85
        "Pair of Jacks",	//JJK84
        "Pair of Jacks",	//JJK83
        "Pair of Jacks",	//JJK82
        "Pair of Jacks",	//JJK76
        "Pair of Jacks",	//JJK75
        "Pair of Jacks",	//JJK74
        "Pair of Jacks",	//JJK73
        "Pair of Jacks",	//JJK72
        "Pair of Jacks",	//JJK65
        "Pair of Jacks",	//JJK64
        "Pair of Jacks",	//JJK63
        "Pair of Jacks",	//JJK62
        "Pair of Jacks",	//JJK54
        "Pair of Jacks",	//JJK53
        "Pair of Jacks",	//JJK52
        "Pair of Jacks",	//JJK43
        "Pair of Jacks",	//JJK42
        "Pair of Jacks",	//JJK32
        "Pair of Jacks",	//JJQT9
        "Pair of Jacks",	//JJQT8
        "Pair of Jacks",	//JJQT7
        "Pair of Jacks",	//JJQT6
        "Pair of Jacks",	//JJQT5
        "Pair of Jacks",	//JJQT4
        "Pair of Jacks",	//JJQT3
        "Pair of Jacks",	//JJQT2
        "Pair of Jacks",	//JJQ98
        "Pair of Jacks",	//JJQ97
        "Pair of Jacks",	//JJQ96
        "Pair of Jacks",	//JJQ95
        "Pair of Jacks",	//JJQ94
        "Pair of Jacks",	//JJQ93
        "Pair of Jacks",	//JJQ92
        "Pair of Jacks",	//JJQ87
        "Pair of Jacks",	//JJQ86
        "Pair of Jacks",	//JJQ85
        "Pair of Jacks",	//JJQ84
        "Pair of Jacks",	//JJQ83
        "Pair of Jacks",	//JJQ82
        "Pair of Jacks",	//JJQ76
        "Pair of Jacks",	//JJQ75
        "Pair of Jacks",	//JJQ74
        "Pair of Jacks",	//JJQ73
        "Pair of Jacks",	//JJQ72
        "Pair of Jacks",	//JJQ65
        "Pair of Jacks",	//JJQ64
        "Pair of Jacks",	//JJQ63
        "Pair of Jacks",	//JJQ62
        "Pair of Jacks",	//JJQ54
        "Pair of Jacks",	//JJQ53
        "Pair of Jacks",	//JJQ52
        "Pair of Jacks",	//JJQ43
        "Pair of Jacks",	//JJQ42
        "Pair of Jacks",	//JJQ32
        "Pair of Jacks",	//JJT98
        "Pair of Jacks",	//JJT97
        "Pair of Jacks",	//JJT96
        "Pair of Jacks",	//JJT95
        "Pair of Jacks",	//JJT94
        "Pair of Jacks",	//JJT93
        "Pair of Jacks",	//JJT92
        "Pair of Jacks",	//JJT87
        "Pair of Jacks",	//JJT86
        "Pair of Jacks",	//JJT85
        "Pair of Jacks",	//JJT84
        "Pair of Jacks",	//JJT83
        "Pair of Jacks",	//JJT82
        "Pair of Jacks",	//JJT76
        "Pair of Jacks",	//JJT75
        "Pair of Jacks",	//JJT74
        "Pair of Jacks",	//JJT73
        "Pair of Jacks",	//JJT72
        "Pair of Jacks",	//JJT65
        "Pair of Jacks",	//JJT64
        "Pair of Jacks",	//JJT63
        "Pair of Jacks",	//JJT62
        "Pair of Jacks",	//JJT54
        "Pair of Jacks",	//JJT53
        "Pair of Jacks",	//JJT52
        "Pair of Jacks",	//JJT43
        "Pair of Jacks",	//JJT42
        "Pair of Jacks",	//JJT32
        "Pair of Jacks",	//JJ987
        "Pair of Jacks",	//JJ986
        "Pair of Jacks",	//JJ985
        "Pair of Jacks",	//JJ984
        "Pair of Jacks",	//JJ983
        "Pair of Jacks",	//JJ982
        "Pair of Jacks",	//JJ976
        "Pair of Jacks",	//JJ975
        "Pair of Jacks",	//JJ974
        "Pair of Jacks",	//JJ973
        "Pair of Jacks",	//JJ972
        "Pair of Jacks",	//JJ965
        "Pair of Jacks",	//JJ964
        "Pair of Jacks",	//JJ963
        "Pair of Jacks",	//JJ962
        "Pair of Jacks",	//JJ954
        "Pair of Jacks",	//JJ953
        "Pair of Jacks",	//JJ952
        "Pair of Jacks",	//JJ943
        "Pair of Jacks",	//JJ942
        "Pair of Jacks",	//JJ932
        "Pair of Jacks",	//JJ876
        "Pair of Jacks",	//JJ875
        "Pair of Jacks",	//JJ874
        "Pair of Jacks",	//JJ873
        "Pair of Jacks",	//JJ872
        "Pair of Jacks",	//JJ865
        "Pair of Jacks",	//JJ864
        "Pair of Jacks",	//JJ863
        "Pair of Jacks",	//JJ862
        "Pair of Jacks",	//JJ854
        "Pair of Jacks",	//JJ853
        "Pair of Jacks",	//JJ852
        "Pair of Jacks",	//JJ843
        "Pair of Jacks",	//JJ842
        "Pair of Jacks",	//JJ832
        "Pair of Jacks",	//JJ765
        "Pair of Jacks",	//JJ764
        "Pair of Jacks",	//JJ763
        "Pair of Jacks",	//JJ762
        "Pair of Jacks",	//JJ754
        "Pair of Jacks",	//JJ753
        "Pair of Jacks",	//JJ752
        "Pair of Jacks",	//JJ743
        "Pair of Jacks",	//JJ742
        "Pair of Jacks",	//JJ732
        "Pair of Jacks",	//JJ654
        "Pair of Jacks",	//JJ653
        "Pair of Jacks",	//JJ652
        "Pair of Jacks",	//JJ643
        "Pair of Jacks",	//JJ642
        "Pair of Jacks",	//JJ632
        "Pair of Jacks",	//JJ543
        "Pair of Jacks",	//JJ542
        "Pair of Jacks",	//JJ532
        "Pair of Jacks",	//JJ432
        "Pair of Tens",	//TTAKQ
        "Pair of Tens",	//TTAKJ
        "Pair of Tens",	//TTAK9
        "Pair of Tens",	//TTAK8
        "Pair of Tens",	//TTAK7
        "Pair of Tens",	//TTAK6
        "Pair of Tens",	//TTAK5
        "Pair of Tens",	//TTAK4
        "Pair of Tens",	//TTAK3
        "Pair of Tens",	//TTAK2
        "Pair of Tens",	//TTAQJ
        "Pair of Tens",	//TTAQ9
        "Pair of Tens",	//TTAQ8
        "Pair of Tens",	//TTAQ7
        "Pair of Tens",	//TTAQ6
        "Pair of Tens",	//TTAQ5
        "Pair of Tens",	//TTAQ4
        "Pair of Tens",	//TTAQ3
        "Pair of Tens",	//TTAQ2
        "Pair of Tens",	//TTAJ9
        "Pair of Tens",	//TTAJ8
        "Pair of Tens",	//TTAJ7
        "Pair of Tens",	//TTAJ6
        "Pair of Tens",	//TTAJ5
        "Pair of Tens",	//TTAJ4
        "Pair of Tens",	//TTAJ3
        "Pair of Tens",	//TTAJ2
        "Pair of Tens",	//TTA98
        "Pair of Tens",	//TTA97
        "Pair of Tens",	//TTA96
        "Pair of Tens",	//TTA95
        "Pair of Tens",	//TTA94
        "Pair of Tens",	//TTA93
        "Pair of Tens",	//TTA92
        "Pair of Tens",	//TTA87
        "Pair of Tens",	//TTA86
        "Pair of Tens",	//TTA85
        "Pair of Tens",	//TTA84
        "Pair of Tens",	//TTA83
        "Pair of Tens",	//TTA82
        "Pair of Tens",	//TTA76
        "Pair of Tens",	//TTA75
        "Pair of Tens",	//TTA74
        "Pair of Tens",	//TTA73
        "Pair of Tens",	//TTA72
        "Pair of Tens",	//TTA65
        "Pair of Tens",	//TTA64
        "Pair of Tens",	//TTA63
        "Pair of Tens",	//TTA62
        "Pair of Tens",	//TTA54
        "Pair of Tens",	//TTA53
        "Pair of Tens",	//TTA52
        "Pair of Tens",	//TTA43
        "Pair of Tens",	//TTA42
        "Pair of Tens",	//TTA32
        "Pair of Tens",	//TTKQJ
        "Pair of Tens",	//TTKQ9
        "Pair of Tens",	//TTKQ8
        "Pair of Tens",	//TTKQ7
        "Pair of Tens",	//TTKQ6
        "Pair of Tens",	//TTKQ5
        "Pair of Tens",	//TTKQ4
        "Pair of Tens",	//TTKQ3
        "Pair of Tens",	//TTKQ2
        "Pair of Tens",	//TTKJ9
        "Pair of Tens",	//TTKJ8
        "Pair of Tens",	//TTKJ7
        "Pair of Tens",	//TTKJ6
        "Pair of Tens",	//TTKJ5
        "Pair of Tens",	//TTKJ4
        "Pair of Tens",	//TTKJ3
        "Pair of Tens",	//TTKJ2
        "Pair of Tens",	//TTK98
        "Pair of Tens",	//TTK97
        "Pair of Tens",	//TTK96
        "Pair of Tens",	//TTK95
        "Pair of Tens",	//TTK94
        "Pair of Tens",	//TTK93
        "Pair of Tens",	//TTK92
        "Pair of Tens",	//TTK87
        "Pair of Tens",	//TTK86
        "Pair of Tens",	//TTK85
        "Pair of Tens",	//TTK84
        "Pair of Tens",	//TTK83
        "Pair of Tens",	//TTK82
        "Pair of Tens",	//TTK76
        "Pair of Tens",	//TTK75
        "Pair of Tens",	//TTK74
        "Pair of Tens",	//TTK73
        "Pair of Tens",	//TTK72
        "Pair of Tens",	//TTK65
        "Pair of Tens",	//TTK64
        "Pair of Tens",	//TTK63
        "Pair of Tens",	//TTK62
        "Pair of Tens",	//TTK54
        "Pair of Tens",	//TTK53
        "Pair of Tens",	//TTK52
        "Pair of Tens",	//TTK43
        "Pair of Tens",	//TTK42
        "Pair of Tens",	//TTK32
        "Pair of Tens",	//TTQJ9
        "Pair of Tens",	//TTQJ8
        "Pair of Tens",	//TTQJ7
        "Pair of Tens",	//TTQJ6
        "Pair of Tens",	//TTQJ5
        "Pair of Tens",	//TTQJ4
        "Pair of Tens",	//TTQJ3
        "Pair of Tens",	//TTQJ2
        "Pair of Tens",	//TTQ98
        "Pair of Tens",	//TTQ97
        "Pair of Tens",	//TTQ96
        "Pair of Tens",	//TTQ95
        "Pair of Tens",	//TTQ94
        "Pair of Tens",	//TTQ93
        "Pair of Tens",	//TTQ92
        "Pair of Tens",	//TTQ87
        "Pair of Tens",	//TTQ86
        "Pair of Tens",	//TTQ85
        "Pair of Tens",	//TTQ84
        "Pair of Tens",	//TTQ83
        "Pair of Tens",	//TTQ82
        "Pair of Tens",	//TTQ76
        "Pair of Tens",	//TTQ75
        "Pair of Tens",	//TTQ74
        "Pair of Tens",	//TTQ73
        "Pair of Tens",	//TTQ72
        "Pair of Tens",	//TTQ65
        "Pair of Tens",	//TTQ64
        "Pair of Tens",	//TTQ63
        "Pair of Tens",	//TTQ62
        "Pair of Tens",	//TTQ54
        "Pair of Tens",	//TTQ53
        "Pair of Tens",	//TTQ52
        "Pair of Tens",	//TTQ43
        "Pair of Tens",	//TTQ42
        "Pair of Tens",	//TTQ32
        "Pair of Tens",	//TTJ98
        "Pair of Tens",	//TTJ97
        "Pair of Tens",	//TTJ96
        "Pair of Tens",	//TTJ95
        "Pair of Tens",	//TTJ94
        "Pair of Tens",	//TTJ93
        "Pair of Tens",	//TTJ92
        "Pair of Tens",	//TTJ87
        "Pair of Tens",	//TTJ86
        "Pair of Tens",	//TTJ85
        "Pair of Tens",	//TTJ84
        "Pair of Tens",	//TTJ83
        "Pair of Tens",	//TTJ82
        "Pair of Tens",	//TTJ76
        "Pair of Tens",	//TTJ75
        "Pair of Tens",	//TTJ74
        "Pair of Tens",	//TTJ73
        "Pair of Tens",	//TTJ72
        "Pair of Tens",	//TTJ65
        "Pair of Tens",	//TTJ64
        "Pair of Tens",	//TTJ63
        "Pair of Tens",	//TTJ62
        "Pair of Tens",	//TTJ54
        "Pair of Tens",	//TTJ53
        "Pair of Tens",	//TTJ52
        "Pair of Tens",	//TTJ43
        "Pair of Tens",	//TTJ42
        "Pair of Tens",	//TTJ32
        "Pair of Tens",	//TT987
        "Pair of Tens",	//TT986
        "Pair of Tens",	//TT985
        "Pair of Tens",	//TT984
        "Pair of Tens",	//TT983
        "Pair of Tens",	//TT982
        "Pair of Tens",	//TT976
        "Pair of Tens",	//TT975
        "Pair of Tens",	//TT974
        "Pair of Tens",	//TT973
        "Pair of Tens",	//TT972
        "Pair of Tens",	//TT965
        "Pair of Tens",	//TT964
        "Pair of Tens",	//TT963
        "Pair of Tens",	//TT962
        "Pair of Tens",	//TT954
        "Pair of Tens",	//TT953
        "Pair of Tens",	//TT952
        "Pair of Tens",	//TT943
        "Pair of Tens",	//TT942
        "Pair of Tens",	//TT932
        "Pair of Tens",	//TT876
        "Pair of Tens",	//TT875
        "Pair of Tens",	//TT874
        "Pair of Tens",	//TT873
        "Pair of Tens",	//TT872
        "Pair of Tens",	//TT865
        "Pair of Tens",	//TT864
        "Pair of Tens",	//TT863
        "Pair of Tens",	//TT862
        "Pair of Tens",	//TT854
        "Pair of Tens",	//TT853
        "Pair of Tens",	//TT852
        "Pair of Tens",	//TT843
        "Pair of Tens",	//TT842
        "Pair of Tens",	//TT832
        "Pair of Tens",	//TT765
        "Pair of Tens",	//TT764
        "Pair of Tens",	//TT763
        "Pair of Tens",	//TT762
        "Pair of Tens",	//TT754
        "Pair of Tens",	//TT753
        "Pair of Tens",	//TT752
        "Pair of Tens",	//TT743
        "Pair of Tens",	//TT742
        "Pair of Tens",	//TT732
        "Pair of Tens",	//TT654
        "Pair of Tens",	//TT653
        "Pair of Tens",	//TT652
        "Pair of Tens",	//TT643
        "Pair of Tens",	//TT642
        "Pair of Tens",	//TT632
        "Pair of Tens",	//TT543
        "Pair of Tens",	//TT542
        "Pair of Tens",	//TT532
        "Pair of Tens",	//TT432
        "Pair of Nines",	//99AKQ
        "Pair of Nines",	//99AKJ
        "Pair of Nines",	//99AKT
        "Pair of Nines",	//99AK8
        "Pair of Nines",	//99AK7
        "Pair of Nines",	//99AK6
        "Pair of Nines",	//99AK5
        "Pair of Nines",	//99AK4
        "Pair of Nines",	//99AK3
        "Pair of Nines",	//99AK2
        "Pair of Nines",	//99AQJ
        "Pair of Nines",	//99AQT
        "Pair of Nines",	//99AQ8
        "Pair of Nines",	//99AQ7
        "Pair of Nines",	//99AQ6
        "Pair of Nines",	//99AQ5
        "Pair of Nines",	//99AQ4
        "Pair of Nines",	//99AQ3
        "Pair of Nines",	//99AQ2
        "Pair of Nines",	//99AJT
        "Pair of Nines",	//99AJ8
        "Pair of Nines",	//99AJ7
        "Pair of Nines",	//99AJ6
        "Pair of Nines",	//99AJ5
        "Pair of Nines",	//99AJ4
        "Pair of Nines",	//99AJ3
        "Pair of Nines",	//99AJ2
        "Pair of Nines",	//99AT8
        "Pair of Nines",	//99AT7
        "Pair of Nines",	//99AT6
        "Pair of Nines",	//99AT5
        "Pair of Nines",	//99AT4
        "Pair of Nines",	//99AT3
        "Pair of Nines",	//99AT2
        "Pair of Nines",	//99A87
        "Pair of Nines",	//99A86
        "Pair of Nines",	//99A85
        "Pair of Nines",	//99A84
        "Pair of Nines",	//99A83
        "Pair of Nines",	//99A82
        "Pair of Nines",	//99A76
        "Pair of Nines",	//99A75
        "Pair of Nines",	//99A74
        "Pair of Nines",	//99A73
        "Pair of Nines",	//99A72
        "Pair of Nines",	//99A65
        "Pair of Nines",	//99A64
        "Pair of Nines",	//99A63
        "Pair of Nines",	//99A62
        "Pair of Nines",	//99A54
        "Pair of Nines",	//99A53
        "Pair of Nines",	//99A52
        "Pair of Nines",	//99A43
        "Pair of Nines",	//99A42
        "Pair of Nines",	//99A32
        "Pair of Nines",	//99KQJ
        "Pair of Nines",	//99KQT
        "Pair of Nines",	//99KQ8
        "Pair of Nines",	//99KQ7
        "Pair of Nines",	//99KQ6
        "Pair of Nines",	//99KQ5
        "Pair of Nines",	//99KQ4
        "Pair of Nines",	//99KQ3
        "Pair of Nines",	//99KQ2
        "Pair of Nines",	//99KJT
        "Pair of Nines",	//99KJ8
        "Pair of Nines",	//99KJ7
        "Pair of Nines",	//99KJ6
        "Pair of Nines",	//99KJ5
        "Pair of Nines",	//99KJ4
        "Pair of Nines",	//99KJ3
        "Pair of Nines",	//99KJ2
        "Pair of Nines",	//99KT8
        "Pair of Nines",	//99KT7
        "Pair of Nines",	//99KT6
        "Pair of Nines",	//99KT5
        "Pair of Nines",	//99KT4
        "Pair of Nines",	//99KT3
        "Pair of Nines",	//99KT2
        "Pair of Nines",	//99K87
        "Pair of Nines",	//99K86
        "Pair of Nines",	//99K85
        "Pair of Nines",	//99K84
        "Pair of Nines",	//99K83
        "Pair of Nines",	//99K82
        "Pair of Nines",	//99K76
        "Pair of Nines",	//99K75
        "Pair of Nines",	//99K74
        "Pair of Nines",	//99K73
        "Pair of Nines",	//99K72
        "Pair of Nines",	//99K65
        "Pair of Nines",	//99K64
        "Pair of Nines",	//99K63
        "Pair of Nines",	//99K62
        "Pair of Nines",	//99K54
        "Pair of Nines",	//99K53
        "Pair of Nines",	//99K52
        "Pair of Nines",	//99K43
        "Pair of Nines",	//99K42
        "Pair of Nines",	//99K32
        "Pair of Nines",	//99QJT
        "Pair of Nines",	//99QJ8
        "Pair of Nines",	//99QJ7
        "Pair of Nines",	//99QJ6
        "Pair of Nines",	//99QJ5
        "Pair of Nines",	//99QJ4
        "Pair of Nines",	//99QJ3
        "Pair of Nines",	//99QJ2
        "Pair of Nines",	//99QT8
        "Pair of Nines",	//99QT7
        "Pair of Nines",	//99QT6
        "Pair of Nines",	//99QT5
        "Pair of Nines",	//99QT4
        "Pair of Nines",	//99QT3
        "Pair of Nines",	//99QT2
        "Pair of Nines",	//99Q87
        "Pair of Nines",	//99Q86
        "Pair of Nines",	//99Q85
        "Pair of Nines",	//99Q84
        "Pair of Nines",	//99Q83
        "Pair of Nines",	//99Q82
        "Pair of Nines",	//99Q76
        "Pair of Nines",	//99Q75
        "Pair of Nines",	//99Q74
        "Pair of Nines",	//99Q73
        "Pair of Nines",	//99Q72
        "Pair of Nines",	//99Q65
        "Pair of Nines",	//99Q64
        "Pair of Nines",	//99Q63
        "Pair of Nines",	//99Q62
        "Pair of Nines",	//99Q54
        "Pair of Nines",	//99Q53
        "Pair of Nines",	//99Q52
        "Pair of Nines",	//99Q43
        "Pair of Nines",	//99Q42
        "Pair of Nines",	//99Q32
        "Pair of Nines",	//99JT8
        "Pair of Nines",	//99JT7
        "Pair of Nines",	//99JT6
        "Pair of Nines",	//99JT5
        "Pair of Nines",	//99JT4
        "Pair of Nines",	//99JT3
        "Pair of Nines",	//99JT2
        "Pair of Nines",	//99J87
        "Pair of Nines",	//99J86
        "Pair of Nines",	//99J85
        "Pair of Nines",	//99J84
        "Pair of Nines",	//99J83
        "Pair of Nines",	//99J82
        "Pair of Nines",	//99J76
        "Pair of Nines",	//99J75
        "Pair of Nines",	//99J74
        "Pair of Nines",	//99J73
        "Pair of Nines",	//99J72
        "Pair of Nines",	//99J65
        "Pair of Nines",	//99J64
        "Pair of Nines",	//99J63
        "Pair of Nines",	//99J62
        "Pair of Nines",	//99J54
        "Pair of Nines",	//99J53
        "Pair of Nines",	//99J52
        "Pair of Nines",	//99J43
        "Pair of Nines",	//99J42
        "Pair of Nines",	//99J32
        "Pair of Nines",	//99T87
        "Pair of Nines",	//99T86
        "Pair of Nines",	//99T85
        "Pair of Nines",	//99T84
        "Pair of Nines",	//99T83
        "Pair of Nines",	//99T82
        "Pair of Nines",	//99T76
        "Pair of Nines",	//99T75
        "Pair of Nines",	//99T74
        "Pair of Nines",	//99T73
        "Pair of Nines",	//99T72
        "Pair of Nines",	//99T65
        "Pair of Nines",	//99T64
        "Pair of Nines",	//99T63
        "Pair of Nines",	//99T62
        "Pair of Nines",	//99T54
        "Pair of Nines",	//99T53
        "Pair of Nines",	//99T52
        "Pair of Nines",	//99T43
        "Pair of Nines",	//99T42
        "Pair of Nines",	//99T32
        "Pair of Nines",	//99876
        "Pair of Nines",	//99875
        "Pair of Nines",	//99874
        "Pair of Nines",	//99873
        "Pair of Nines",	//99872
        "Pair of Nines",	//99865
        "Pair of Nines",	//99864
        "Pair of Nines",	//99863
        "Pair of Nines",	//99862
        "Pair of Nines",	//99854
        "Pair of Nines",	//99853
        "Pair of Nines",	//99852
        "Pair of Nines",	//99843
        "Pair of Nines",	//99842
        "Pair of Nines",	//99832
        "Pair of Nines",	//99765
        "Pair of Nines",	//99764
        "Pair of Nines",	//99763
        "Pair of Nines",	//99762
        "Pair of Nines",	//99754
        "Pair of Nines",	//99753
        "Pair of Nines",	//99752
        "Pair of Nines",	//99743
        "Pair of Nines",	//99742
        "Pair of Nines",	//99732
        "Pair of Nines",	//99654
        "Pair of Nines",	//99653
        "Pair of Nines",	//99652
        "Pair of Nines",	//99643
        "Pair of Nines",	//99642
        "Pair of Nines",	//99632
        "Pair of Nines",	//99543
        "Pair of Nines",	//99542
        "Pair of Nines",	//99532
        "Pair of Nines",	//99432
        "Pair of Eights",	//88AKQ
        "Pair of Eights",	//88AKJ
        "Pair of Eights",	//88AKT
        "Pair of Eights",	//88AK9
        "Pair of Eights",	//88AK7
        "Pair of Eights",	//88AK6
        "Pair of Eights",	//88AK5
        "Pair of Eights",	//88AK4
        "Pair of Eights",	//88AK3
        "Pair of Eights",	//88AK2
        "Pair of Eights",	//88AQJ
        "Pair of Eights",	//88AQT
        "Pair of Eights",	//88AQ9
        "Pair of Eights",	//88AQ7
        "Pair of Eights",	//88AQ6
        "Pair of Eights",	//88AQ5
        "Pair of Eights",	//88AQ4
        "Pair of Eights",	//88AQ3
        "Pair of Eights",	//88AQ2
        "Pair of Eights",	//88AJT
        "Pair of Eights",	//88AJ9
        "Pair of Eights",	//88AJ7
        "Pair of Eights",	//88AJ6
        "Pair of Eights",	//88AJ5
        "Pair of Eights",	//88AJ4
        "Pair of Eights",	//88AJ3
        "Pair of Eights",	//88AJ2
        "Pair of Eights",	//88AT9
        "Pair of Eights",	//88AT7
        "Pair of Eights",	//88AT6
        "Pair of Eights",	//88AT5
        "Pair of Eights",	//88AT4
        "Pair of Eights",	//88AT3
        "Pair of Eights",	//88AT2
        "Pair of Eights",	//88A97
        "Pair of Eights",	//88A96
        "Pair of Eights",	//88A95
        "Pair of Eights",	//88A94
        "Pair of Eights",	//88A93
        "Pair of Eights",	//88A92
        "Pair of Eights",	//88A76
        "Pair of Eights",	//88A75
        "Pair of Eights",	//88A74
        "Pair of Eights",	//88A73
        "Pair of Eights",	//88A72
        "Pair of Eights",	//88A65
        "Pair of Eights",	//88A64
        "Pair of Eights",	//88A63
        "Pair of Eights",	//88A62
        "Pair of Eights",	//88A54
        "Pair of Eights",	//88A53
        "Pair of Eights",	//88A52
        "Pair of Eights",	//88A43
        "Pair of Eights",	//88A42
        "Pair of Eights",	//88A32
        "Pair of Eights",	//88KQJ
        "Pair of Eights",	//88KQT
        "Pair of Eights",	//88KQ9
        "Pair of Eights",	//88KQ7
        "Pair of Eights",	//88KQ6
        "Pair of Eights",	//88KQ5
        "Pair of Eights",	//88KQ4
        "Pair of Eights",	//88KQ3
        "Pair of Eights",	//88KQ2
        "Pair of Eights",	//88KJT
        "Pair of Eights",	//88KJ9
        "Pair of Eights",	//88KJ7
        "Pair of Eights",	//88KJ6
        "Pair of Eights",	//88KJ5
        "Pair of Eights",	//88KJ4
        "Pair of Eights",	//88KJ3
        "Pair of Eights",	//88KJ2
        "Pair of Eights",	//88KT9
        "Pair of Eights",	//88KT7
        "Pair of Eights",	//88KT6
        "Pair of Eights",	//88KT5
        "Pair of Eights",	//88KT4
        "Pair of Eights",	//88KT3
        "Pair of Eights",	//88KT2
        "Pair of Eights",	//88K97
        "Pair of Eights",	//88K96
        "Pair of Eights",	//88K95
        "Pair of Eights",	//88K94
        "Pair of Eights",	//88K93
        "Pair of Eights",	//88K92
        "Pair of Eights",	//88K76
        "Pair of Eights",	//88K75
        "Pair of Eights",	//88K74
        "Pair of Eights",	//88K73
        "Pair of Eights",	//88K72
        "Pair of Eights",	//88K65
        "Pair of Eights",	//88K64
        "Pair of Eights",	//88K63
        "Pair of Eights",	//88K62
        "Pair of Eights",	//88K54
        "Pair of Eights",	//88K53
        "Pair of Eights",	//88K52
        "Pair of Eights",	//88K43
        "Pair of Eights",	//88K42
        "Pair of Eights",	//88K32
        "Pair of Eights",	//88QJT
        "Pair of Eights",	//88QJ9
        "Pair of Eights",	//88QJ7
        "Pair of Eights",	//88QJ6
        "Pair of Eights",	//88QJ5
        "Pair of Eights",	//88QJ4
        "Pair of Eights",	//88QJ3
        "Pair of Eights",	//88QJ2
        "Pair of Eights",	//88QT9
        "Pair of Eights",	//88QT7
        "Pair of Eights",	//88QT6
        "Pair of Eights",	//88QT5
        "Pair of Eights",	//88QT4
        "Pair of Eights",	//88QT3
        "Pair of Eights",	//88QT2
        "Pair of Eights",	//88Q97
        "Pair of Eights",	//88Q96
        "Pair of Eights",	//88Q95
        "Pair of Eights",	//88Q94
        "Pair of Eights",	//88Q93
        "Pair of Eights",	//88Q92
        "Pair of Eights",	//88Q76
        "Pair of Eights",	//88Q75
        "Pair of Eights",	//88Q74
        "Pair of Eights",	//88Q73
        "Pair of Eights",	//88Q72
        "Pair of Eights",	//88Q65
        "Pair of Eights",	//88Q64
        "Pair of Eights",	//88Q63
        "Pair of Eights",	//88Q62
        "Pair of Eights",	//88Q54
        "Pair of Eights",	//88Q53
        "Pair of Eights",	//88Q52
        "Pair of Eights",	//88Q43
        "Pair of Eights",	//88Q42
        "Pair of Eights",	//88Q32
        "Pair of Eights",	//88JT9
        "Pair of Eights",	//88JT7
        "Pair of Eights",	//88JT6
        "Pair of Eights",	//88JT5
        "Pair of Eights",	//88JT4
        "Pair of Eights",	//88JT3
        "Pair of Eights",	//88JT2
        "Pair of Eights",	//88J97
        "Pair of Eights",	//88J96
        "Pair of Eights",	//88J95
        "Pair of Eights",	//88J94
        "Pair of Eights",	//88J93
        "Pair of Eights",	//88J92
        "Pair of Eights",	//88J76
        "Pair of Eights",	//88J75
        "Pair of Eights",	//88J74
        "Pair of Eights",	//88J73
        "Pair of Eights",	//88J72
        "Pair of Eights",	//88J65
        "Pair of Eights",	//88J64
        "Pair of Eights",	//88J63
        "Pair of Eights",	//88J62
        "Pair of Eights",	//88J54
        "Pair of Eights",	//88J53
        "Pair of Eights",	//88J52
        "Pair of Eights",	//88J43
        "Pair of Eights",	//88J42
        "Pair of Eights",	//88J32
        "Pair of Eights",	//88T97
        "Pair of Eights",	//88T96
        "Pair of Eights",	//88T95
        "Pair of Eights",	//88T94
        "Pair of Eights",	//88T93
        "Pair of Eights",	//88T92
        "Pair of Eights",	//88T76
        "Pair of Eights",	//88T75
        "Pair of Eights",	//88T74
        "Pair of Eights",	//88T73
        "Pair of Eights",	//88T72
        "Pair of Eights",	//88T65
        "Pair of Eights",	//88T64
        "Pair of Eights",	//88T63
        "Pair of Eights",	//88T62
        "Pair of Eights",	//88T54
        "Pair of Eights",	//88T53
        "Pair of Eights",	//88T52
        "Pair of Eights",	//88T43
        "Pair of Eights",	//88T42
        "Pair of Eights",	//88T32
        "Pair of Eights",	//88976
        "Pair of Eights",	//88975
        "Pair of Eights",	//88974
        "Pair of Eights",	//88973
        "Pair of Eights",	//88972
        "Pair of Eights",	//88965
        "Pair of Eights",	//88964
        "Pair of Eights",	//88963
        "Pair of Eights",	//88962
        "Pair of Eights",	//88954
        "Pair of Eights",	//88953
        "Pair of Eights",	//88952
        "Pair of Eights",	//88943
        "Pair of Eights",	//88942
        "Pair of Eights",	//88932
        "Pair of Eights",	//88765
        "Pair of Eights",	//88764
        "Pair of Eights",	//88763
        "Pair of Eights",	//88762
        "Pair of Eights",	//88754
        "Pair of Eights",	//88753
        "Pair of Eights",	//88752
        "Pair of Eights",	//88743
        "Pair of Eights",	//88742
        "Pair of Eights",	//88732
        "Pair of Eights",	//88654
        "Pair of Eights",	//88653
        "Pair of Eights",	//88652
        "Pair of Eights",	//88643
        "Pair of Eights",	//88642
        "Pair of Eights",	//88632
        "Pair of Eights",	//88543
        "Pair of Eights",	//88542
        "Pair of Eights",	//88532
        "Pair of Eights",	//88432
        "Pair of Sevens",	//77AKQ
        "Pair of Sevens",	//77AKJ
        "Pair of Sevens",	//77AKT
        "Pair of Sevens",	//77AK9
        "Pair of Sevens",	//77AK8
        "Pair of Sevens",	//77AK6
        "Pair of Sevens",	//77AK5
        "Pair of Sevens",	//77AK4
        "Pair of Sevens",	//77AK3
        "Pair of Sevens",	//77AK2
        "Pair of Sevens",	//77AQJ
        "Pair of Sevens",	//77AQT
        "Pair of Sevens",	//77AQ9
        "Pair of Sevens",	//77AQ8
        "Pair of Sevens",	//77AQ6
        "Pair of Sevens",	//77AQ5
        "Pair of Sevens",	//77AQ4
        "Pair of Sevens",	//77AQ3
        "Pair of Sevens",	//77AQ2
        "Pair of Sevens",	//77AJT
        "Pair of Sevens",	//77AJ9
        "Pair of Sevens",	//77AJ8
        "Pair of Sevens",	//77AJ6
        "Pair of Sevens",	//77AJ5
        "Pair of Sevens",	//77AJ4
        "Pair of Sevens",	//77AJ3
        "Pair of Sevens",	//77AJ2
        "Pair of Sevens",	//77AT9
        "Pair of Sevens",	//77AT8
        "Pair of Sevens",	//77AT6
        "Pair of Sevens",	//77AT5
        "Pair of Sevens",	//77AT4
        "Pair of Sevens",	//77AT3
        "Pair of Sevens",	//77AT2
        "Pair of Sevens",	//77A98
        "Pair of Sevens",	//77A96
        "Pair of Sevens",	//77A95
        "Pair of Sevens",	//77A94
        "Pair of Sevens",	//77A93
        "Pair of Sevens",	//77A92
        "Pair of Sevens",	//77A86
        "Pair of Sevens",	//77A85
        "Pair of Sevens",	//77A84
        "Pair of Sevens",	//77A83
        "Pair of Sevens",	//77A82
        "Pair of Sevens",	//77A65
        "Pair of Sevens",	//77A64
        "Pair of Sevens",	//77A63
        "Pair of Sevens",	//77A62
        "Pair of Sevens",	//77A54
        "Pair of Sevens",	//77A53
        "Pair of Sevens",	//77A52
        "Pair of Sevens",	//77A43
        "Pair of Sevens",	//77A42
        "Pair of Sevens",	//77A32
        "Pair of Sevens",	//77KQJ
        "Pair of Sevens",	//77KQT
        "Pair of Sevens",	//77KQ9
        "Pair of Sevens",	//77KQ8
        "Pair of Sevens",	//77KQ6
        "Pair of Sevens",	//77KQ5
        "Pair of Sevens",	//77KQ4
        "Pair of Sevens",	//77KQ3
        "Pair of Sevens",	//77KQ2
        "Pair of Sevens",	//77KJT
        "Pair of Sevens",	//77KJ9
        "Pair of Sevens",	//77KJ8
        "Pair of Sevens",	//77KJ6
        "Pair of Sevens",	//77KJ5
        "Pair of Sevens",	//77KJ4
        "Pair of Sevens",	//77KJ3
        "Pair of Sevens",	//77KJ2
        "Pair of Sevens",	//77KT9
        "Pair of Sevens",	//77KT8
        "Pair of Sevens",	//77KT6
        "Pair of Sevens",	//77KT5
        "Pair of Sevens",	//77KT4
        "Pair of Sevens",	//77KT3
        "Pair of Sevens",	//77KT2
        "Pair of Sevens",	//77K98
        "Pair of Sevens",	//77K96
        "Pair of Sevens",	//77K95
        "Pair of Sevens",	//77K94
        "Pair of Sevens",	//77K93
        "Pair of Sevens",	//77K92
        "Pair of Sevens",	//77K86
        "Pair of Sevens",	//77K85
        "Pair of Sevens",	//77K84
        "Pair of Sevens",	//77K83
        "Pair of Sevens",	//77K82
        "Pair of Sevens",	//77K65
        "Pair of Sevens",	//77K64
        "Pair of Sevens",	//77K63
        "Pair of Sevens",	//77K62
        "Pair of Sevens",	//77K54
        "Pair of Sevens",	//77K53
        "Pair of Sevens",	//77K52
        "Pair of Sevens",	//77K43
        "Pair of Sevens",	//77K42
        "Pair of Sevens",	//77K32
        "Pair of Sevens",	//77QJT
        "Pair of Sevens",	//77QJ9
        "Pair of Sevens",	//77QJ8
        "Pair of Sevens",	//77QJ6
        "Pair of Sevens",	//77QJ5
        "Pair of Sevens",	//77QJ4
        "Pair of Sevens",	//77QJ3
        "Pair of Sevens",	//77QJ2
        "Pair of Sevens",	//77QT9
        "Pair of Sevens",	//77QT8
        "Pair of Sevens",	//77QT6
        "Pair of Sevens",	//77QT5
        "Pair of Sevens",	//77QT4
        "Pair of Sevens",	//77QT3
        "Pair of Sevens",	//77QT2
        "Pair of Sevens",	//77Q98
        "Pair of Sevens",	//77Q96
        "Pair of Sevens",	//77Q95
        "Pair of Sevens",	//77Q94
        "Pair of Sevens",	//77Q93
        "Pair of Sevens",	//77Q92
        "Pair of Sevens",	//77Q86
        "Pair of Sevens",	//77Q85
        "Pair of Sevens",	//77Q84
        "Pair of Sevens",	//77Q83
        "Pair of Sevens",	//77Q82
        "Pair of Sevens",	//77Q65
        "Pair of Sevens",	//77Q64
        "Pair of Sevens",	//77Q63
        "Pair of Sevens",	//77Q62
        "Pair of Sevens",	//77Q54
        "Pair of Sevens",	//77Q53
        "Pair of Sevens",	//77Q52
        "Pair of Sevens",	//77Q43
        "Pair of Sevens",	//77Q42
        "Pair of Sevens",	//77Q32
        "Pair of Sevens",	//77JT9
        "Pair of Sevens",	//77JT8
        "Pair of Sevens",	//77JT6
        "Pair of Sevens",	//77JT5
        "Pair of Sevens",	//77JT4
        "Pair of Sevens",	//77JT3
        "Pair of Sevens",	//77JT2
        "Pair of Sevens",	//77J98
        "Pair of Sevens",	//77J96
        "Pair of Sevens",	//77J95
        "Pair of Sevens",	//77J94
        "Pair of Sevens",	//77J93
        "Pair of Sevens",	//77J92
        "Pair of Sevens",	//77J86
        "Pair of Sevens",	//77J85
        "Pair of Sevens",	//77J84
        "Pair of Sevens",	//77J83
        "Pair of Sevens",	//77J82
        "Pair of Sevens",	//77J65
        "Pair of Sevens",	//77J64
        "Pair of Sevens",	//77J63
        "Pair of Sevens",	//77J62
        "Pair of Sevens",	//77J54
        "Pair of Sevens",	//77J53
        "Pair of Sevens",	//77J52
        "Pair of Sevens",	//77J43
        "Pair of Sevens",	//77J42
        "Pair of Sevens",	//77J32
        "Pair of Sevens",	//77T98
        "Pair of Sevens",	//77T96
        "Pair of Sevens",	//77T95
        "Pair of Sevens",	//77T94
        "Pair of Sevens",	//77T93
        "Pair of Sevens",	//77T92
        "Pair of Sevens",	//77T86
        "Pair of Sevens",	//77T85
        "Pair of Sevens",	//77T84
        "Pair of Sevens",	//77T83
        "Pair of Sevens",	//77T82
        "Pair of Sevens",	//77T65
        "Pair of Sevens",	//77T64
        "Pair of Sevens",	//77T63
        "Pair of Sevens",	//77T62
        "Pair of Sevens",	//77T54
        "Pair of Sevens",	//77T53
        "Pair of Sevens",	//77T52
        "Pair of Sevens",	//77T43
        "Pair of Sevens",	//77T42
        "Pair of Sevens",	//77T32
        "Pair of Sevens",	//77986
        "Pair of Sevens",	//77985
        "Pair of Sevens",	//77984
        "Pair of Sevens",	//77983
        "Pair of Sevens",	//77982
        "Pair of Sevens",	//77965
        "Pair of Sevens",	//77964
        "Pair of Sevens",	//77963
        "Pair of Sevens",	//77962
        "Pair of Sevens",	//77954
        "Pair of Sevens",	//77953
        "Pair of Sevens",	//77952
        "Pair of Sevens",	//77943
        "Pair of Sevens",	//77942
        "Pair of Sevens",	//77932
        "Pair of Sevens",	//77865
        "Pair of Sevens",	//77864
        "Pair of Sevens",	//77863
        "Pair of Sevens",	//77862
        "Pair of Sevens",	//77854
        "Pair of Sevens",	//77853
        "Pair of Sevens",	//77852
        "Pair of Sevens",	//77843
        "Pair of Sevens",	//77842
        "Pair of Sevens",	//77832
        "Pair of Sevens",	//77654
        "Pair of Sevens",	//77653
        "Pair of Sevens",	//77652
        "Pair of Sevens",	//77643
        "Pair of Sevens",	//77642
        "Pair of Sevens",	//77632
        "Pair of Sevens",	//77543
        "Pair of Sevens",	//77542
        "Pair of Sevens",	//77532
        "Pair of Sevens",	//77432
        "Pair of Sixes",	//66AKQ
        "Pair of Sixes",	//66AKJ
        "Pair of Sixes",	//66AKT
        "Pair of Sixes",	//66AK9
        "Pair of Sixes",	//66AK8
        "Pair of Sixes",	//66AK7
        "Pair of Sixes",	//66AK5
        "Pair of Sixes",	//66AK4
        "Pair of Sixes",	//66AK3
        "Pair of Sixes",	//66AK2
        "Pair of Sixes",	//66AQJ
        "Pair of Sixes",	//66AQT
        "Pair of Sixes",	//66AQ9
        "Pair of Sixes",	//66AQ8
        "Pair of Sixes",	//66AQ7
        "Pair of Sixes",	//66AQ5
        "Pair of Sixes",	//66AQ4
        "Pair of Sixes",	//66AQ3
        "Pair of Sixes",	//66AQ2
        "Pair of Sixes",	//66AJT
        "Pair of Sixes",	//66AJ9
        "Pair of Sixes",	//66AJ8
        "Pair of Sixes",	//66AJ7
        "Pair of Sixes",	//66AJ5
        "Pair of Sixes",	//66AJ4
        "Pair of Sixes",	//66AJ3
        "Pair of Sixes",	//66AJ2
        "Pair of Sixes",	//66AT9
        "Pair of Sixes",	//66AT8
        "Pair of Sixes",	//66AT7
        "Pair of Sixes",	//66AT5
        "Pair of Sixes",	//66AT4
        "Pair of Sixes",	//66AT3
        "Pair of Sixes",	//66AT2
        "Pair of Sixes",	//66A98
        "Pair of Sixes",	//66A97
        "Pair of Sixes",	//66A95
        "Pair of Sixes",	//66A94
        "Pair of Sixes",	//66A93
        "Pair of Sixes",	//66A92
        "Pair of Sixes",	//66A87
        "Pair of Sixes",	//66A85
        "Pair of Sixes",	//66A84
        "Pair of Sixes",	//66A83
        "Pair of Sixes",	//66A82
        "Pair of Sixes",	//66A75
        "Pair of Sixes",	//66A74
        "Pair of Sixes",	//66A73
        "Pair of Sixes",	//66A72
        "Pair of Sixes",	//66A54
        "Pair of Sixes",	//66A53
        "Pair of Sixes",	//66A52
        "Pair of Sixes",	//66A43
        "Pair of Sixes",	//66A42
        "Pair of Sixes",	//66A32
        "Pair of Sixes",	//66KQJ
        "Pair of Sixes",	//66KQT
        "Pair of Sixes",	//66KQ9
        "Pair of Sixes",	//66KQ8
        "Pair of Sixes",	//66KQ7
        "Pair of Sixes",	//66KQ5
        "Pair of Sixes",	//66KQ4
        "Pair of Sixes",	//66KQ3
        "Pair of Sixes",	//66KQ2
        "Pair of Sixes",	//66KJT
        "Pair of Sixes",	//66KJ9
        "Pair of Sixes",	//66KJ8
        "Pair of Sixes",	//66KJ7
        "Pair of Sixes",	//66KJ5
        "Pair of Sixes",	//66KJ4
        "Pair of Sixes",	//66KJ3
        "Pair of Sixes",	//66KJ2
        "Pair of Sixes",	//66KT9
        "Pair of Sixes",	//66KT8
        "Pair of Sixes",	//66KT7
        "Pair of Sixes",	//66KT5
        "Pair of Sixes",	//66KT4
        "Pair of Sixes",	//66KT3
        "Pair of Sixes",	//66KT2
        "Pair of Sixes",	//66K98
        "Pair of Sixes",	//66K97
        "Pair of Sixes",	//66K95
        "Pair of Sixes",	//66K94
        "Pair of Sixes",	//66K93
        "Pair of Sixes",	//66K92
        "Pair of Sixes",	//66K87
        "Pair of Sixes",	//66K85
        "Pair of Sixes",	//66K84
        "Pair of Sixes",	//66K83
        "Pair of Sixes",	//66K82
        "Pair of Sixes",	//66K75
        "Pair of Sixes",	//66K74
        "Pair of Sixes",	//66K73
        "Pair of Sixes",	//66K72
        "Pair of Sixes",	//66K54
        "Pair of Sixes",	//66K53
        "Pair of Sixes",	//66K52
        "Pair of Sixes",	//66K43
        "Pair of Sixes",	//66K42
        "Pair of Sixes",	//66K32
        "Pair of Sixes",	//66QJT
        "Pair of Sixes",	//66QJ9
        "Pair of Sixes",	//66QJ8
        "Pair of Sixes",	//66QJ7
        "Pair of Sixes",	//66QJ5
        "Pair of Sixes",	//66QJ4
        "Pair of Sixes",	//66QJ3
        "Pair of Sixes",	//66QJ2
        "Pair of Sixes",	//66QT9
        "Pair of Sixes",	//66QT8
        "Pair of Sixes",	//66QT7
        "Pair of Sixes",	//66QT5
        "Pair of Sixes",	//66QT4
        "Pair of Sixes",	//66QT3
        "Pair of Sixes",	//66QT2
        "Pair of Sixes",	//66Q98
        "Pair of Sixes",	//66Q97
        "Pair of Sixes",	//66Q95
        "Pair of Sixes",	//66Q94
        "Pair of Sixes",	//66Q93
        "Pair of Sixes",	//66Q92
        "Pair of Sixes",	//66Q87
        "Pair of Sixes",	//66Q85
        "Pair of Sixes",	//66Q84
        "Pair of Sixes",	//66Q83
        "Pair of Sixes",	//66Q82
        "Pair of Sixes",	//66Q75
        "Pair of Sixes",	//66Q74
        "Pair of Sixes",	//66Q73
        "Pair of Sixes",	//66Q72
        "Pair of Sixes",	//66Q54
        "Pair of Sixes",	//66Q53
        "Pair of Sixes",	//66Q52
        "Pair of Sixes",	//66Q43
        "Pair of Sixes",	//66Q42
        "Pair of Sixes",	//66Q32
        "Pair of Sixes",	//66JT9
        "Pair of Sixes",	//66JT8
        "Pair of Sixes",	//66JT7
        "Pair of Sixes",	//66JT5
        "Pair of Sixes",	//66JT4
        "Pair of Sixes",	//66JT3
        "Pair of Sixes",	//66JT2
        "Pair of Sixes",	//66J98
        "Pair of Sixes",	//66J97
        "Pair of Sixes",	//66J95
        "Pair of Sixes",	//66J94
        "Pair of Sixes",	//66J93
        "Pair of Sixes",	//66J92
        "Pair of Sixes",	//66J87
        "Pair of Sixes",	//66J85
        "Pair of Sixes",	//66J84
        "Pair of Sixes",	//66J83
        "Pair of Sixes",	//66J82
        "Pair of Sixes",	//66J75
        "Pair of Sixes",	//66J74
        "Pair of Sixes",	//66J73
        "Pair of Sixes",	//66J72
        "Pair of Sixes",	//66J54
        "Pair of Sixes",	//66J53
        "Pair of Sixes",	//66J52
        "Pair of Sixes",	//66J43
        "Pair of Sixes",	//66J42
        "Pair of Sixes",	//66J32
        "Pair of Sixes",	//66T98
        "Pair of Sixes",	//66T97
        "Pair of Sixes",	//66T95
        "Pair of Sixes",	//66T94
        "Pair of Sixes",	//66T93
        "Pair of Sixes",	//66T92
        "Pair of Sixes",	//66T87
        "Pair of Sixes",	//66T85
        "Pair of Sixes",	//66T84
        "Pair of Sixes",	//66T83
        "Pair of Sixes",	//66T82
        "Pair of Sixes",	//66T75
        "Pair of Sixes",	//66T74
        "Pair of Sixes",	//66T73
        "Pair of Sixes",	//66T72
        "Pair of Sixes",	//66T54
        "Pair of Sixes",	//66T53
        "Pair of Sixes",	//66T52
        "Pair of Sixes",	//66T43
        "Pair of Sixes",	//66T42
        "Pair of Sixes",	//66T32
        "Pair of Sixes",	//66987
        "Pair of Sixes",	//66985
        "Pair of Sixes",	//66984
        "Pair of Sixes",	//66983
        "Pair of Sixes",	//66982
        "Pair of Sixes",	//66975
        "Pair of Sixes",	//66974
        "Pair of Sixes",	//66973
        "Pair of Sixes",	//66972
        "Pair of Sixes",	//66954
        "Pair of Sixes",	//66953
        "Pair of Sixes",	//66952
        "Pair of Sixes",	//66943
        "Pair of Sixes",	//66942
        "Pair of Sixes",	//66932
        "Pair of Sixes",	//66875
        "Pair of Sixes",	//66874
        "Pair of Sixes",	//66873
        "Pair of Sixes",	//66872
        "Pair of Sixes",	//66854
        "Pair of Sixes",	//66853
        "Pair of Sixes",	//66852
        "Pair of Sixes",	//66843
        "Pair of Sixes",	//66842
        "Pair of Sixes",	//66832
        "Pair of Sixes",	//66754
        "Pair of Sixes",	//66753
        "Pair of Sixes",	//66752
        "Pair of Sixes",	//66743
        "Pair of Sixes",	//66742
        "Pair of Sixes",	//66732
        "Pair of Sixes",	//66543
        "Pair of Sixes",	//66542
        "Pair of Sixes",	//66532
        "Pair of Sixes",	//66432
        "Pair of Fives",	//55AKQ
        "Pair of Fives",	//55AKJ
        "Pair of Fives",	//55AKT
        "Pair of Fives",	//55AK9
        "Pair of Fives",	//55AK8
        "Pair of Fives",	//55AK7
        "Pair of Fives",	//55AK6
        "Pair of Fives",	//55AK4
        "Pair of Fives",	//55AK3
        "Pair of Fives",	//55AK2
        "Pair of Fives",	//55AQJ
        "Pair of Fives",	//55AQT
        "Pair of Fives",	//55AQ9
        "Pair of Fives",	//55AQ8
        "Pair of Fives",	//55AQ7
        "Pair of Fives",	//55AQ6
        "Pair of Fives",	//55AQ4
        "Pair of Fives",	//55AQ3
        "Pair of Fives",	//55AQ2
        "Pair of Fives",	//55AJT
        "Pair of Fives",	//55AJ9
        "Pair of Fives",	//55AJ8
        "Pair of Fives",	//55AJ7
        "Pair of Fives",	//55AJ6
        "Pair of Fives",	//55AJ4
        "Pair of Fives",	//55AJ3
        "Pair of Fives",	//55AJ2
        "Pair of Fives",	//55AT9
        "Pair of Fives",	//55AT8
        "Pair of Fives",	//55AT7
        "Pair of Fives",	//55AT6
        "Pair of Fives",	//55AT4
        "Pair of Fives",	//55AT3
        "Pair of Fives",	//55AT2
        "Pair of Fives",	//55A98
        "Pair of Fives",	//55A97
        "Pair of Fives",	//55A96
        "Pair of Fives",	//55A94
        "Pair of Fives",	//55A93
        "Pair of Fives",	//55A92
        "Pair of Fives",	//55A87
        "Pair of Fives",	//55A86
        "Pair of Fives",	//55A84
        "Pair of Fives",	//55A83
        "Pair of Fives",	//55A82
        "Pair of Fives",	//55A76
        "Pair of Fives",	//55A74
        "Pair of Fives",	//55A73
        "Pair of Fives",	//55A72
        "Pair of Fives",	//55A64
        "Pair of Fives",	//55A63
        "Pair of Fives",	//55A62
        "Pair of Fives",	//55A43
        "Pair of Fives",	//55A42
        "Pair of Fives",	//55A32
        "Pair of Fives",	//55KQJ
        "Pair of Fives",	//55KQT
        "Pair of Fives",	//55KQ9
        "Pair of Fives",	//55KQ8
        "Pair of Fives",	//55KQ7
        "Pair of Fives",	//55KQ6
        "Pair of Fives",	//55KQ4
        "Pair of Fives",	//55KQ3
        "Pair of Fives",	//55KQ2
        "Pair of Fives",	//55KJT
        "Pair of Fives",	//55KJ9
        "Pair of Fives",	//55KJ8
        "Pair of Fives",	//55KJ7
        "Pair of Fives",	//55KJ6
        "Pair of Fives",	//55KJ4
        "Pair of Fives",	//55KJ3
        "Pair of Fives",	//55KJ2
        "Pair of Fives",	//55KT9
        "Pair of Fives",	//55KT8
        "Pair of Fives",	//55KT7
        "Pair of Fives",	//55KT6
        "Pair of Fives",	//55KT4
        "Pair of Fives",	//55KT3
        "Pair of Fives",	//55KT2
        "Pair of Fives",	//55K98
        "Pair of Fives",	//55K97
        "Pair of Fives",	//55K96
        "Pair of Fives",	//55K94
        "Pair of Fives",	//55K93
        "Pair of Fives",	//55K92
        "Pair of Fives",	//55K87
        "Pair of Fives",	//55K86
        "Pair of Fives",	//55K84
        "Pair of Fives",	//55K83
        "Pair of Fives",	//55K82
        "Pair of Fives",	//55K76
        "Pair of Fives",	//55K74
        "Pair of Fives",	//55K73
        "Pair of Fives",	//55K72
        "Pair of Fives",	//55K64
        "Pair of Fives",	//55K63
        "Pair of Fives",	//55K62
        "Pair of Fives",	//55K43
        "Pair of Fives",	//55K42
        "Pair of Fives",	//55K32
        "Pair of Fives",	//55QJT
        "Pair of Fives",	//55QJ9
        "Pair of Fives",	//55QJ8
        "Pair of Fives",	//55QJ7
        "Pair of Fives",	//55QJ6
        "Pair of Fives",	//55QJ4
        "Pair of Fives",	//55QJ3
        "Pair of Fives",	//55QJ2
        "Pair of Fives",	//55QT9
        "Pair of Fives",	//55QT8
        "Pair of Fives",	//55QT7
        "Pair of Fives",	//55QT6
        "Pair of Fives",	//55QT4
        "Pair of Fives",	//55QT3
        "Pair of Fives",	//55QT2
        "Pair of Fives",	//55Q98
        "Pair of Fives",	//55Q97
        "Pair of Fives",	//55Q96
        "Pair of Fives",	//55Q94
        "Pair of Fives",	//55Q93
        "Pair of Fives",	//55Q92
        "Pair of Fives",	//55Q87
        "Pair of Fives",	//55Q86
        "Pair of Fives",	//55Q84
        "Pair of Fives",	//55Q83
        "Pair of Fives",	//55Q82
        "Pair of Fives",	//55Q76
        "Pair of Fives",	//55Q74
        "Pair of Fives",	//55Q73
        "Pair of Fives",	//55Q72
        "Pair of Fives",	//55Q64
        "Pair of Fives",	//55Q63
        "Pair of Fives",	//55Q62
        "Pair of Fives",	//55Q43
        "Pair of Fives",	//55Q42
        "Pair of Fives",	//55Q32
        "Pair of Fives",	//55JT9
        "Pair of Fives",	//55JT8
        "Pair of Fives",	//55JT7
        "Pair of Fives",	//55JT6
        "Pair of Fives",	//55JT4
        "Pair of Fives",	//55JT3
        "Pair of Fives",	//55JT2
        "Pair of Fives",	//55J98
        "Pair of Fives",	//55J97
        "Pair of Fives",	//55J96
        "Pair of Fives",	//55J94
        "Pair of Fives",	//55J93
        "Pair of Fives",	//55J92
        "Pair of Fives",	//55J87
        "Pair of Fives",	//55J86
        "Pair of Fives",	//55J84
        "Pair of Fives",	//55J83
        "Pair of Fives",	//55J82
        "Pair of Fives",	//55J76
        "Pair of Fives",	//55J74
        "Pair of Fives",	//55J73
        "Pair of Fives",	//55J72
        "Pair of Fives",	//55J64
        "Pair of Fives",	//55J63
        "Pair of Fives",	//55J62
        "Pair of Fives",	//55J43
        "Pair of Fives",	//55J42
        "Pair of Fives",	//55J32
        "Pair of Fives",	//55T98
        "Pair of Fives",	//55T97
        "Pair of Fives",	//55T96
        "Pair of Fives",	//55T94
        "Pair of Fives",	//55T93
        "Pair of Fives",	//55T92
        "Pair of Fives",	//55T87
        "Pair of Fives",	//55T86
        "Pair of Fives",	//55T84
        "Pair of Fives",	//55T83
        "Pair of Fives",	//55T82
        "Pair of Fives",	//55T76
        "Pair of Fives",	//55T74
        "Pair of Fives",	//55T73
        "Pair of Fives",	//55T72
        "Pair of Fives",	//55T64
        "Pair of Fives",	//55T63
        "Pair of Fives",	//55T62
        "Pair of Fives",	//55T43
        "Pair of Fives",	//55T42
        "Pair of Fives",	//55T32
        "Pair of Fives",	//55987
        "Pair of Fives",	//55986
        "Pair of Fives",	//55984
        "Pair of Fives",	//55983
        "Pair of Fives",	//55982
        "Pair of Fives",	//55976
        "Pair of Fives",	//55974
        "Pair of Fives",	//55973
        "Pair of Fives",	//55972
        "Pair of Fives",	//55964
        "Pair of Fives",	//55963
        "Pair of Fives",	//55962
        "Pair of Fives",	//55943
        "Pair of Fives",	//55942
        "Pair of Fives",	//55932
        "Pair of Fives",	//55876
        "Pair of Fives",	//55874
        "Pair of Fives",	//55873
        "Pair of Fives",	//55872
        "Pair of Fives",	//55864
        "Pair of Fives",	//55863
        "Pair of Fives",	//55862
        "Pair of Fives",	//55843
        "Pair of Fives",	//55842
        "Pair of Fives",	//55832
        "Pair of Fives",	//55764
        "Pair of Fives",	//55763
        "Pair of Fives",	//55762
        "Pair of Fives",	//55743
        "Pair of Fives",	//55742
        "Pair of Fives",	//55732
        "Pair of Fives",	//55643
        "Pair of Fives",	//55642
        "Pair of Fives",	//55632
        "Pair of Fives",	//55432
        "Pair of Fours",	//44AKQ
        "Pair of Fours",	//44AKJ
        "Pair of Fours",	//44AKT
        "Pair of Fours",	//44AK9
        "Pair of Fours",	//44AK8
        "Pair of Fours",	//44AK7
        "Pair of Fours",	//44AK6
        "Pair of Fours",	//44AK5
        "Pair of Fours",	//44AK3
        "Pair of Fours",	//44AK2
        "Pair of Fours",	//44AQJ
        "Pair of Fours",	//44AQT
        "Pair of Fours",	//44AQ9
        "Pair of Fours",	//44AQ8
        "Pair of Fours",	//44AQ7
        "Pair of Fours",	//44AQ6
        "Pair of Fours",	//44AQ5
        "Pair of Fours",	//44AQ3
        "Pair of Fours",	//44AQ2
        "Pair of Fours",	//44AJT
        "Pair of Fours",	//44AJ9
        "Pair of Fours",	//44AJ8
        "Pair of Fours",	//44AJ7
        "Pair of Fours",	//44AJ6
        "Pair of Fours",	//44AJ5
        "Pair of Fours",	//44AJ3
        "Pair of Fours",	//44AJ2
        "Pair of Fours",	//44AT9
        "Pair of Fours",	//44AT8
        "Pair of Fours",	//44AT7
        "Pair of Fours",	//44AT6
        "Pair of Fours",	//44AT5
        "Pair of Fours",	//44AT3
        "Pair of Fours",	//44AT2
        "Pair of Fours",	//44A98
        "Pair of Fours",	//44A97
        "Pair of Fours",	//44A96
        "Pair of Fours",	//44A95
        "Pair of Fours",	//44A93
        "Pair of Fours",	//44A92
        "Pair of Fours",	//44A87
        "Pair of Fours",	//44A86
        "Pair of Fours",	//44A85
        "Pair of Fours",	//44A83
        "Pair of Fours",	//44A82
        "Pair of Fours",	//44A76
        "Pair of Fours",	//44A75
        "Pair of Fours",	//44A73
        "Pair of Fours",	//44A72
        "Pair of Fours",	//44A65
        "Pair of Fours",	//44A63
        "Pair of Fours",	//44A62
        "Pair of Fours",	//44A53
        "Pair of Fours",	//44A52
        "Pair of Fours",	//44A32
        "Pair of Fours",	//44KQJ
        "Pair of Fours",	//44KQT
        "Pair of Fours",	//44KQ9
        "Pair of Fours",	//44KQ8
        "Pair of Fours",	//44KQ7
        "Pair of Fours",	//44KQ6
        "Pair of Fours",	//44KQ5
        "Pair of Fours",	//44KQ3
        "Pair of Fours",	//44KQ2
        "Pair of Fours",	//44KJT
        "Pair of Fours",	//44KJ9
        "Pair of Fours",	//44KJ8
        "Pair of Fours",	//44KJ7
        "Pair of Fours",	//44KJ6
        "Pair of Fours",	//44KJ5
        "Pair of Fours",	//44KJ3
        "Pair of Fours",	//44KJ2
        "Pair of Fours",	//44KT9
        "Pair of Fours",	//44KT8
        "Pair of Fours",	//44KT7
        "Pair of Fours",	//44KT6
        "Pair of Fours",	//44KT5
        "Pair of Fours",	//44KT3
        "Pair of Fours",	//44KT2
        "Pair of Fours",	//44K98
        "Pair of Fours",	//44K97
        "Pair of Fours",	//44K96
        "Pair of Fours",	//44K95
        "Pair of Fours",	//44K93
        "Pair of Fours",	//44K92
        "Pair of Fours",	//44K87
        "Pair of Fours",	//44K86
        "Pair of Fours",	//44K85
        "Pair of Fours",	//44K83
        "Pair of Fours",	//44K82
        "Pair of Fours",	//44K76
        "Pair of Fours",	//44K75
        "Pair of Fours",	//44K73
        "Pair of Fours",	//44K72
        "Pair of Fours",	//44K65
        "Pair of Fours",	//44K63
        "Pair of Fours",	//44K62
        "Pair of Fours",	//44K53
        "Pair of Fours",	//44K52
        "Pair of Fours",	//44K32
        "Pair of Fours",	//44QJT
        "Pair of Fours",	//44QJ9
        "Pair of Fours",	//44QJ8
        "Pair of Fours",	//44QJ7
        "Pair of Fours",	//44QJ6
        "Pair of Fours",	//44QJ5
        "Pair of Fours",	//44QJ3
        "Pair of Fours",	//44QJ2
        "Pair of Fours",	//44QT9
        "Pair of Fours",	//44QT8
        "Pair of Fours",	//44QT7
        "Pair of Fours",	//44QT6
        "Pair of Fours",	//44QT5
        "Pair of Fours",	//44QT3
        "Pair of Fours",	//44QT2
        "Pair of Fours",	//44Q98
        "Pair of Fours",	//44Q97
        "Pair of Fours",	//44Q96
        "Pair of Fours",	//44Q95
        "Pair of Fours",	//44Q93
        "Pair of Fours",	//44Q92
        "Pair of Fours",	//44Q87
        "Pair of Fours",	//44Q86
        "Pair of Fours",	//44Q85
        "Pair of Fours",	//44Q83
        "Pair of Fours",	//44Q82
        "Pair of Fours",	//44Q76
        "Pair of Fours",	//44Q75
        "Pair of Fours",	//44Q73
        "Pair of Fours",	//44Q72
        "Pair of Fours",	//44Q65
        "Pair of Fours",	//44Q63
        "Pair of Fours",	//44Q62
        "Pair of Fours",	//44Q53
        "Pair of Fours",	//44Q52
        "Pair of Fours",	//44Q32
        "Pair of Fours",	//44JT9
        "Pair of Fours",	//44JT8
        "Pair of Fours",	//44JT7
        "Pair of Fours",	//44JT6
        "Pair of Fours",	//44JT5
        "Pair of Fours",	//44JT3
        "Pair of Fours",	//44JT2
        "Pair of Fours",	//44J98
        "Pair of Fours",	//44J97
        "Pair of Fours",	//44J96
        "Pair of Fours",	//44J95
        "Pair of Fours",	//44J93
        "Pair of Fours",	//44J92
        "Pair of Fours",	//44J87
        "Pair of Fours",	//44J86
        "Pair of Fours",	//44J85
        "Pair of Fours",	//44J83
        "Pair of Fours",	//44J82
        "Pair of Fours",	//44J76
        "Pair of Fours",	//44J75
        "Pair of Fours",	//44J73
        "Pair of Fours",	//44J72
        "Pair of Fours",	//44J65
        "Pair of Fours",	//44J63
        "Pair of Fours",	//44J62
        "Pair of Fours",	//44J53
        "Pair of Fours",	//44J52
        "Pair of Fours",	//44J32
        "Pair of Fours",	//44T98
        "Pair of Fours",	//44T97
        "Pair of Fours",	//44T96
        "Pair of Fours",	//44T95
        "Pair of Fours",	//44T93
        "Pair of Fours",	//44T92
        "Pair of Fours",	//44T87
        "Pair of Fours",	//44T86
        "Pair of Fours",	//44T85
        "Pair of Fours",	//44T83
        "Pair of Fours",	//44T82
        "Pair of Fours",	//44T76
        "Pair of Fours",	//44T75
        "Pair of Fours",	//44T73
        "Pair of Fours",	//44T72
        "Pair of Fours",	//44T65
        "Pair of Fours",	//44T63
        "Pair of Fours",	//44T62
        "Pair of Fours",	//44T53
        "Pair of Fours",	//44T52
        "Pair of Fours",	//44T32
        "Pair of Fours",	//44987
        "Pair of Fours",	//44986
        "Pair of Fours",	//44985
        "Pair of Fours",	//44983
        "Pair of Fours",	//44982
        "Pair of Fours",	//44976
        "Pair of Fours",	//44975
        "Pair of Fours",	//44973
        "Pair of Fours",	//44972
        "Pair of Fours",	//44965
        "Pair of Fours",	//44963
        "Pair of Fours",	//44962
        "Pair of Fours",	//44953
        "Pair of Fours",	//44952
        "Pair of Fours",	//44932
        "Pair of Fours",	//44876
        "Pair of Fours",	//44875
        "Pair of Fours",	//44873
        "Pair of Fours",	//44872
        "Pair of Fours",	//44865
        "Pair of Fours",	//44863
        "Pair of Fours",	//44862
        "Pair of Fours",	//44853
        "Pair of Fours",	//44852
        "Pair of Fours",	//44832
        "Pair of Fours",	//44765
        "Pair of Fours",	//44763
        "Pair of Fours",	//44762
        "Pair of Fours",	//44753
        "Pair of Fours",	//44752
        "Pair of Fours",	//44732
        "Pair of Fours",	//44653
        "Pair of Fours",	//44652
        "Pair of Fours",	//44632
        "Pair of Fours",	//44532
        "Pair of Treys",	//33AKQ
        "Pair of Treys",	//33AKJ
        "Pair of Treys",	//33AKT
        "Pair of Treys",	//33AK9
        "Pair of Treys",	//33AK8
        "Pair of Treys",	//33AK7
        "Pair of Treys",	//33AK6
        "Pair of Treys",	//33AK5
        "Pair of Treys",	//33AK4
        "Pair of Treys",	//33AK2
        "Pair of Treys",	//33AQJ
        "Pair of Treys",	//33AQT
        "Pair of Treys",	//33AQ9
        "Pair of Treys",	//33AQ8
        "Pair of Treys",	//33AQ7
        "Pair of Treys",	//33AQ6
        "Pair of Treys",	//33AQ5
        "Pair of Treys",	//33AQ4
        "Pair of Treys",	//33AQ2
        "Pair of Treys",	//33AJT
        "Pair of Treys",	//33AJ9
        "Pair of Treys",	//33AJ8
        "Pair of Treys",	//33AJ7
        "Pair of Treys",	//33AJ6
        "Pair of Treys",	//33AJ5
        "Pair of Treys",	//33AJ4
        "Pair of Treys",	//33AJ2
        "Pair of Treys",	//33AT9
        "Pair of Treys",	//33AT8
        "Pair of Treys",	//33AT7
        "Pair of Treys",	//33AT6
        "Pair of Treys",	//33AT5
        "Pair of Treys",	//33AT4
        "Pair of Treys",	//33AT2
        "Pair of Treys",	//33A98
        "Pair of Treys",	//33A97
        "Pair of Treys",	//33A96
        "Pair of Treys",	//33A95
        "Pair of Treys",	//33A94
        "Pair of Treys",	//33A92
        "Pair of Treys",	//33A87
        "Pair of Treys",	//33A86
        "Pair of Treys",	//33A85
        "Pair of Treys",	//33A84
        "Pair of Treys",	//33A82
        "Pair of Treys",	//33A76
        "Pair of Treys",	//33A75
        "Pair of Treys",	//33A74
        "Pair of Treys",	//33A72
        "Pair of Treys",	//33A65
        "Pair of Treys",	//33A64
        "Pair of Treys",	//33A62
        "Pair of Treys",	//33A54
        "Pair of Treys",	//33A52
        "Pair of Treys",	//33A42
        "Pair of Treys",	//33KQJ
        "Pair of Treys",	//33KQT
        "Pair of Treys",	//33KQ9
        "Pair of Treys",	//33KQ8
        "Pair of Treys",	//33KQ7
        "Pair of Treys",	//33KQ6
        "Pair of Treys",	//33KQ5
        "Pair of Treys",	//33KQ4
        "Pair of Treys",	//33KQ2
        "Pair of Treys",	//33KJT
        "Pair of Treys",	//33KJ9
        "Pair of Treys",	//33KJ8
        "Pair of Treys",	//33KJ7
        "Pair of Treys",	//33KJ6
        "Pair of Treys",	//33KJ5
        "Pair of Treys",	//33KJ4
        "Pair of Treys",	//33KJ2
        "Pair of Treys",	//33KT9
        "Pair of Treys",	//33KT8
        "Pair of Treys",	//33KT7
        "Pair of Treys",	//33KT6
        "Pair of Treys",	//33KT5
        "Pair of Treys",	//33KT4
        "Pair of Treys",	//33KT2
        "Pair of Treys",	//33K98
        "Pair of Treys",	//33K97
        "Pair of Treys",	//33K96
        "Pair of Treys",	//33K95
        "Pair of Treys",	//33K94
        "Pair of Treys",	//33K92
        "Pair of Treys",	//33K87
        "Pair of Treys",	//33K86
        "Pair of Treys",	//33K85
        "Pair of Treys",	//33K84
        "Pair of Treys",	//33K82
        "Pair of Treys",	//33K76
        "Pair of Treys",	//33K75
        "Pair of Treys",	//33K74
        "Pair of Treys",	//33K72
        "Pair of Treys",	//33K65
        "Pair of Treys",	//33K64
        "Pair of Treys",	//33K62
        "Pair of Treys",	//33K54
        "Pair of Treys",	//33K52
        "Pair of Treys",	//33K42
        "Pair of Treys",	//33QJT
        "Pair of Treys",	//33QJ9
        "Pair of Treys",	//33QJ8
        "Pair of Treys",	//33QJ7
        "Pair of Treys",	//33QJ6
        "Pair of Treys",	//33QJ5
        "Pair of Treys",	//33QJ4
        "Pair of Treys",	//33QJ2
        "Pair of Treys",	//33QT9
        "Pair of Treys",	//33QT8
        "Pair of Treys",	//33QT7
        "Pair of Treys",	//33QT6
        "Pair of Treys",	//33QT5
        "Pair of Treys",	//33QT4
        "Pair of Treys",	//33QT2
        "Pair of Treys",	//33Q98
        "Pair of Treys",	//33Q97
        "Pair of Treys",	//33Q96
        "Pair of Treys",	//33Q95
        "Pair of Treys",	//33Q94
        "Pair of Treys",	//33Q92
        "Pair of Treys",	//33Q87
        "Pair of Treys",	//33Q86
        "Pair of Treys",	//33Q85
        "Pair of Treys",	//33Q84
        "Pair of Treys",	//33Q82
        "Pair of Treys",	//33Q76
        "Pair of Treys",	//33Q75
        "Pair of Treys",	//33Q74
        "Pair of Treys",	//33Q72
        "Pair of Treys",	//33Q65
        "Pair of Treys",	//33Q64
        "Pair of Treys",	//33Q62
        "Pair of Treys",	//33Q54
        "Pair of Treys",	//33Q52
        "Pair of Treys",	//33Q42
        "Pair of Treys",	//33JT9
        "Pair of Treys",	//33JT8
        "Pair of Treys",	//33JT7
        "Pair of Treys",	//33JT6
        "Pair of Treys",	//33JT5
        "Pair of Treys",	//33JT4
        "Pair of Treys",	//33JT2
        "Pair of Treys",	//33J98
        "Pair of Treys",	//33J97
        "Pair of Treys",	//33J96
        "Pair of Treys",	//33J95
        "Pair of Treys",	//33J94
        "Pair of Treys",	//33J92
        "Pair of Treys",	//33J87
        "Pair of Treys",	//33J86
        "Pair of Treys",	//33J85
        "Pair of Treys",	//33J84
        "Pair of Treys",	//33J82
        "Pair of Treys",	//33J76
        "Pair of Treys",	//33J75
        "Pair of Treys",	//33J74
        "Pair of Treys",	//33J72
        "Pair of Treys",	//33J65
        "Pair of Treys",	//33J64
        "Pair of Treys",	//33J62
        "Pair of Treys",	//33J54
        "Pair of Treys",	//33J52
        "Pair of Treys",	//33J42
        "Pair of Treys",	//33T98
        "Pair of Treys",	//33T97
        "Pair of Treys",	//33T96
        "Pair of Treys",	//33T95
        "Pair of Treys",	//33T94
        "Pair of Treys",	//33T92
        "Pair of Treys",	//33T87
        "Pair of Treys",	//33T86
        "Pair of Treys",	//33T85
        "Pair of Treys",	//33T84
        "Pair of Treys",	//33T82
        "Pair of Treys",	//33T76
        "Pair of Treys",	//33T75
        "Pair of Treys",	//33T74
        "Pair of Treys",	//33T72
        "Pair of Treys",	//33T65
        "Pair of Treys",	//33T64
        "Pair of Treys",	//33T62
        "Pair of Treys",	//33T54
        "Pair of Treys",	//33T52
        "Pair of Treys",	//33T42
        "Pair of Treys",	//33987
        "Pair of Treys",	//33986
        "Pair of Treys",	//33985
        "Pair of Treys",	//33984
        "Pair of Treys",	//33982
        "Pair of Treys",	//33976
        "Pair of Treys",	//33975
        "Pair of Treys",	//33974
        "Pair of Treys",	//33972
        "Pair of Treys",	//33965
        "Pair of Treys",	//33964
        "Pair of Treys",	//33962
        "Pair of Treys",	//33954
        "Pair of Treys",	//33952
        "Pair of Treys",	//33942
        "Pair of Treys",	//33876
        "Pair of Treys",	//33875
        "Pair of Treys",	//33874
        "Pair of Treys",	//33872
        "Pair of Treys",	//33865
        "Pair of Treys",	//33864
        "Pair of Treys",	//33862
        "Pair of Treys",	//33854
        "Pair of Treys",	//33852
        "Pair of Treys",	//33842
        "Pair of Treys",	//33765
        "Pair of Treys",	//33764
        "Pair of Treys",	//33762
        "Pair of Treys",	//33754
        "Pair of Treys",	//33752
        "Pair of Treys",	//33742
        "Pair of Treys",	//33654
        "Pair of Treys",	//33652
        "Pair of Treys",	//33642
        "Pair of Treys",	//33542
        "Pair of Deuces",	//22AKQ
        "Pair of Deuces",	//22AKJ
        "Pair of Deuces",	//22AKT
        "Pair of Deuces",	//22AK9
        "Pair of Deuces",	//22AK8
        "Pair of Deuces",	//22AK7
        "Pair of Deuces",	//22AK6
        "Pair of Deuces",	//22AK5
        "Pair of Deuces",	//22AK4
        "Pair of Deuces",	//22AK3
        "Pair of Deuces",	//22AQJ
        "Pair of Deuces",	//22AQT
        "Pair of Deuces",	//22AQ9
        "Pair of Deuces",	//22AQ8
        "Pair of Deuces",	//22AQ7
        "Pair of Deuces",	//22AQ6
        "Pair of Deuces",	//22AQ5
        "Pair of Deuces",	//22AQ4
        "Pair of Deuces",	//22AQ3
        "Pair of Deuces",	//22AJT
        "Pair of Deuces",	//22AJ9
        "Pair of Deuces",	//22AJ8
        "Pair of Deuces",	//22AJ7
        "Pair of Deuces",	//22AJ6
        "Pair of Deuces",	//22AJ5
        "Pair of Deuces",	//22AJ4
        "Pair of Deuces",	//22AJ3
        "Pair of Deuces",	//22AT9
        "Pair of Deuces",	//22AT8
        "Pair of Deuces",	//22AT7
        "Pair of Deuces",	//22AT6
        "Pair of Deuces",	//22AT5
        "Pair of Deuces",	//22AT4
        "Pair of Deuces",	//22AT3
        "Pair of Deuces",	//22A98
        "Pair of Deuces",	//22A97
        "Pair of Deuces",	//22A96
        "Pair of Deuces",	//22A95
        "Pair of Deuces",	//22A94
        "Pair of Deuces",	//22A93
        "Pair of Deuces",	//22A87
        "Pair of Deuces",	//22A86
        "Pair of Deuces",	//22A85
        "Pair of Deuces",	//22A84
        "Pair of Deuces",	//22A83
        "Pair of Deuces",	//22A76
        "Pair of Deuces",	//22A75
        "Pair of Deuces",	//22A74
        "Pair of Deuces",	//22A73
        "Pair of Deuces",	//22A65
        "Pair of Deuces",	//22A64
        "Pair of Deuces",	//22A63
        "Pair of Deuces",	//22A54
        "Pair of Deuces",	//22A53
        "Pair of Deuces",	//22A43
        "Pair of Deuces",	//22KQJ
        "Pair of Deuces",	//22KQT
        "Pair of Deuces",	//22KQ9
        "Pair of Deuces",	//22KQ8
        "Pair of Deuces",	//22KQ7
        "Pair of Deuces",	//22KQ6
        "Pair of Deuces",	//22KQ5
        "Pair of Deuces",	//22KQ4
        "Pair of Deuces",	//22KQ3
        "Pair of Deuces",	//22KJT
        "Pair of Deuces",	//22KJ9
        "Pair of Deuces",	//22KJ8
        "Pair of Deuces",	//22KJ7
        "Pair of Deuces",	//22KJ6
        "Pair of Deuces",	//22KJ5
        "Pair of Deuces",	//22KJ4
        "Pair of Deuces",	//22KJ3
        "Pair of Deuces",	//22KT9
        "Pair of Deuces",	//22KT8
        "Pair of Deuces",	//22KT7
        "Pair of Deuces",	//22KT6
        "Pair of Deuces",	//22KT5
        "Pair of Deuces",	//22KT4
        "Pair of Deuces",	//22KT3
        "Pair of Deuces",	//22K98
        "Pair of Deuces",	//22K97
        "Pair of Deuces",	//22K96
        "Pair of Deuces",	//22K95
        "Pair of Deuces",	//22K94
        "Pair of Deuces",	//22K93
        "Pair of Deuces",	//22K87
        "Pair of Deuces",	//22K86
        "Pair of Deuces",	//22K85
        "Pair of Deuces",	//22K84
        "Pair of Deuces",	//22K83
        "Pair of Deuces",	//22K76
        "Pair of Deuces",	//22K75
        "Pair of Deuces",	//22K74
        "Pair of Deuces",	//22K73
        "Pair of Deuces",	//22K65
        "Pair of Deuces",	//22K64
        "Pair of Deuces",	//22K63
        "Pair of Deuces",	//22K54
        "Pair of Deuces",	//22K53
        "Pair of Deuces",	//22K43
        "Pair of Deuces",	//22QJT
        "Pair of Deuces",	//22QJ9
        "Pair of Deuces",	//22QJ8
        "Pair of Deuces",	//22QJ7
        "Pair of Deuces",	//22QJ6
        "Pair of Deuces",	//22QJ5
        "Pair of Deuces",	//22QJ4
        "Pair of Deuces",	//22QJ3
        "Pair of Deuces",	//22QT9
        "Pair of Deuces",	//22QT8
        "Pair of Deuces",	//22QT7
        "Pair of Deuces",	//22QT6
        "Pair of Deuces",	//22QT5
        "Pair of Deuces",	//22QT4
        "Pair of Deuces",	//22QT3
        "Pair of Deuces",	//22Q98
        "Pair of Deuces",	//22Q97
        "Pair of Deuces",	//22Q96
        "Pair of Deuces",	//22Q95
        "Pair of Deuces",	//22Q94
        "Pair of Deuces",	//22Q93
        "Pair of Deuces",	//22Q87
        "Pair of Deuces",	//22Q86
        "Pair of Deuces",	//22Q85
        "Pair of Deuces",	//22Q84
        "Pair of Deuces",	//22Q83
        "Pair of Deuces",	//22Q76
        "Pair of Deuces",	//22Q75
        "Pair of Deuces",	//22Q74
        "Pair of Deuces",	//22Q73
        "Pair of Deuces",	//22Q65
        "Pair of Deuces",	//22Q64
        "Pair of Deuces",	//22Q63
        "Pair of Deuces",	//22Q54
        "Pair of Deuces",	//22Q53
        "Pair of Deuces",	//22Q43
        "Pair of Deuces",	//22JT9
        "Pair of Deuces",	//22JT8
        "Pair of Deuces",	//22JT7
        "Pair of Deuces",	//22JT6
        "Pair of Deuces",	//22JT5
        "Pair of Deuces",	//22JT4
        "Pair of Deuces",	//22JT3
        "Pair of Deuces",	//22J98
        "Pair of Deuces",	//22J97
        "Pair of Deuces",	//22J96
        "Pair of Deuces",	//22J95
        "Pair of Deuces",	//22J94
        "Pair of Deuces",	//22J93
        "Pair of Deuces",	//22J87
        "Pair of Deuces",	//22J86
        "Pair of Deuces",	//22J85
        "Pair of Deuces",	//22J84
        "Pair of Deuces",	//22J83
        "Pair of Deuces",	//22J76
        "Pair of Deuces",	//22J75
        "Pair of Deuces",	//22J74
        "Pair of Deuces",	//22J73
        "Pair of Deuces",	//22J65
        "Pair of Deuces",	//22J64
        "Pair of Deuces",	//22J63
        "Pair of Deuces",	//22J54
        "Pair of Deuces",	//22J53
        "Pair of Deuces",	//22J43
        "Pair of Deuces",	//22T98
        "Pair of Deuces",	//22T97
        "Pair of Deuces",	//22T96
        "Pair of Deuces",	//22T95
        "Pair of Deuces",	//22T94
        "Pair of Deuces",	//22T93
        "Pair of Deuces",	//22T87
        "Pair of Deuces",	//22T86
        "Pair of Deuces",	//22T85
        "Pair of Deuces",	//22T84
        "Pair of Deuces",	//22T83
        "Pair of Deuces",	//22T76
        "Pair of Deuces",	//22T75
        "Pair of Deuces",	//22T74
        "Pair of Deuces",	//22T73
        "Pair of Deuces",	//22T65
        "Pair of Deuces",	//22T64
        "Pair of Deuces",	//22T63
        "Pair of Deuces",	//22T54
        "Pair of Deuces",	//22T53
        "Pair of Deuces",	//22T43
        "Pair of Deuces",	//22987
        "Pair of Deuces",	//22986
        "Pair of Deuces",	//22985
        "Pair of Deuces",	//22984
        "Pair of Deuces",	//22983
        "Pair of Deuces",	//22976
        "Pair of Deuces",	//22975
        "Pair of Deuces",	//22974
        "Pair of Deuces",	//22973
        "Pair of Deuces",	//22965
        "Pair of Deuces",	//22964
        "Pair of Deuces",	//22963
        "Pair of Deuces",	//22954
        "Pair of Deuces",	//22953
        "Pair of Deuces",	//22943
        "Pair of Deuces",	//22876
        "Pair of Deuces",	//22875
        "Pair of Deuces",	//22874
        "Pair of Deuces",	//22873
        "Pair of Deuces",	//22865
        "Pair of Deuces",	//22864
        "Pair of Deuces",	//22863
        "Pair of Deuces",	//22854
        "Pair of Deuces",	//22853
        "Pair of Deuces",	//22843
        "Pair of Deuces",	//22765
        "Pair of Deuces",	//22764
        "Pair of Deuces",	//22763
        "Pair of Deuces",	//22754
        "Pair of Deuces",	//22753
        "Pair of Deuces",	//22743
        "Pair of Deuces",	//22654
        "Pair of Deuces",	//22653
        "Pair of Deuces",	//22643
        "Pair of Deuces",	//22543
        "Ace-High",	//AKQJ9
        "Ace-High",	//AKQJ8
        "Ace-High",	//AKQJ7
        "Ace-High",	//AKQJ6
        "Ace-High",	//AKQJ5
        "Ace-High",	//AKQJ4
        "Ace-High",	//AKQJ3
        "Ace-High",	//AKQJ2
        "Ace-High",	//AKQT9
        "Ace-High",	//AKQT8
        "Ace-High",	//AKQT7
        "Ace-High",	//AKQT6
        "Ace-High",	//AKQT5
        "Ace-High",	//AKQT4
        "Ace-High",	//AKQT3
        "Ace-High",	//AKQT2
        "Ace-High",	//AKQ98
        "Ace-High",	//AKQ97
        "Ace-High",	//AKQ96
        "Ace-High",	//AKQ95
        "Ace-High",	//AKQ94
        "Ace-High",	//AKQ93
        "Ace-High",	//AKQ92
        "Ace-High",	//AKQ87
        "Ace-High",	//AKQ86
        "Ace-High",	//AKQ85
        "Ace-High",	//AKQ84
        "Ace-High",	//AKQ83
        "Ace-High",	//AKQ82
        "Ace-High",	//AKQ76
        "Ace-High",	//AKQ75
        "Ace-High",	//AKQ74
        "Ace-High",	//AKQ73
        "Ace-High",	//AKQ72
        "Ace-High",	//AKQ65
        "Ace-High",	//AKQ64
        "Ace-High",	//AKQ63
        "Ace-High",	//AKQ62
        "Ace-High",	//AKQ54
        "Ace-High",	//AKQ53
        "Ace-High",	//AKQ52
        "Ace-High",	//AKQ43
        "Ace-High",	//AKQ42
        "Ace-High",	//AKQ32
        "Ace-High",	//AKJT9
        "Ace-High",	//AKJT8
        "Ace-High",	//AKJT7
        "Ace-High",	//AKJT6
        "Ace-High",	//AKJT5
        "Ace-High",	//AKJT4
        "Ace-High",	//AKJT3
        "Ace-High",	//AKJT2
        "Ace-High",	//AKJ98
        "Ace-High",	//AKJ97
        "Ace-High",	//AKJ96
        "Ace-High",	//AKJ95
        "Ace-High",	//AKJ94
        "Ace-High",	//AKJ93
        "Ace-High",	//AKJ92
        "Ace-High",	//AKJ87
        "Ace-High",	//AKJ86
        "Ace-High",	//AKJ85
        "Ace-High",	//AKJ84
        "Ace-High",	//AKJ83
        "Ace-High",	//AKJ82
        "Ace-High",	//AKJ76
        "Ace-High",	//AKJ75
        "Ace-High",	//AKJ74
        "Ace-High",	//AKJ73
        "Ace-High",	//AKJ72
        "Ace-High",	//AKJ65
        "Ace-High",	//AKJ64
        "Ace-High",	//AKJ63
        "Ace-High",	//AKJ62
        "Ace-High",	//AKJ54
        "Ace-High",	//AKJ53
        "Ace-High",	//AKJ52
        "Ace-High",	//AKJ43
        "Ace-High",	//AKJ42
        "Ace-High",	//AKJ32
        "Ace-High",	//AKT98
        "Ace-High",	//AKT97
        "Ace-High",	//AKT96
        "Ace-High",	//AKT95
        "Ace-High",	//AKT94
        "Ace-High",	//AKT93
        "Ace-High",	//AKT92
        "Ace-High",	//AKT87
        "Ace-High",	//AKT86
        "Ace-High",	//AKT85
        "Ace-High",	//AKT84
        "Ace-High",	//AKT83
        "Ace-High",	//AKT82
        "Ace-High",	//AKT76
        "Ace-High",	//AKT75
        "Ace-High",	//AKT74
        "Ace-High",	//AKT73
        "Ace-High",	//AKT72
        "Ace-High",	//AKT65
        "Ace-High",	//AKT64
        "Ace-High",	//AKT63
        "Ace-High",	//AKT62
        "Ace-High",	//AKT54
        "Ace-High",	//AKT53
        "Ace-High",	//AKT52
        "Ace-High",	//AKT43
        "Ace-High",	//AKT42
        "Ace-High",	//AKT32
        "Ace-High",	//AK987
        "Ace-High",	//AK986
        "Ace-High",	//AK985
        "Ace-High",	//AK984
        "Ace-High",	//AK983
        "Ace-High",	//AK982
        "Ace-High",	//AK976
        "Ace-High",	//AK975
        "Ace-High",	//AK974
        "Ace-High",	//AK973
        "Ace-High",	//AK972
        "Ace-High",	//AK965
        "Ace-High",	//AK964
        "Ace-High",	//AK963
        "Ace-High",	//AK962
        "Ace-High",	//AK954
        "Ace-High",	//AK953
        "Ace-High",	//AK952
        "Ace-High",	//AK943
        "Ace-High",	//AK942
        "Ace-High",	//AK932
        "Ace-High",	//AK876
        "Ace-High",	//AK875
        "Ace-High",	//AK874
        "Ace-High",	//AK873
        "Ace-High",	//AK872
        "Ace-High",	//AK865
        "Ace-High",	//AK864
        "Ace-High",	//AK863
        "Ace-High",	//AK862
        "Ace-High",	//AK854
        "Ace-High",	//AK853
        "Ace-High",	//AK852
        "Ace-High",	//AK843
        "Ace-High",	//AK842
        "Ace-High",	//AK832
        "Ace-High",	//AK765
        "Ace-High",	//AK764
        "Ace-High",	//AK763
        "Ace-High",	//AK762
        "Ace-High",	//AK754
        "Ace-High",	//AK753
        "Ace-High",	//AK752
        "Ace-High",	//AK743
        "Ace-High",	//AK742
        "Ace-High",	//AK732
        "Ace-High",	//AK654
        "Ace-High",	//AK653
        "Ace-High",	//AK652
        "Ace-High",	//AK643
        "Ace-High",	//AK642
        "Ace-High",	//AK632
        "Ace-High",	//AK543
        "Ace-High",	//AK542
        "Ace-High",	//AK532
        "Ace-High",	//AK432
        "Ace-High",	//AQJT9
        "Ace-High",	//AQJT8
        "Ace-High",	//AQJT7
        "Ace-High",	//AQJT6
        "Ace-High",	//AQJT5
        "Ace-High",	//AQJT4
        "Ace-High",	//AQJT3
        "Ace-High",	//AQJT2
        "Ace-High",	//AQJ98
        "Ace-High",	//AQJ97
        "Ace-High",	//AQJ96
        "Ace-High",	//AQJ95
        "Ace-High",	//AQJ94
        "Ace-High",	//AQJ93
        "Ace-High",	//AQJ92
        "Ace-High",	//AQJ87
        "Ace-High",	//AQJ86
        "Ace-High",	//AQJ85
        "Ace-High",	//AQJ84
        "Ace-High",	//AQJ83
        "Ace-High",	//AQJ82
        "Ace-High",	//AQJ76
        "Ace-High",	//AQJ75
        "Ace-High",	//AQJ74
        "Ace-High",	//AQJ73
        "Ace-High",	//AQJ72
        "Ace-High",	//AQJ65
        "Ace-High",	//AQJ64
        "Ace-High",	//AQJ63
        "Ace-High",	//AQJ62
        "Ace-High",	//AQJ54
        "Ace-High",	//AQJ53
        "Ace-High",	//AQJ52
        "Ace-High",	//AQJ43
        "Ace-High",	//AQJ42
        "Ace-High",	//AQJ32
        "Ace-High",	//AQT98
        "Ace-High",	//AQT97
        "Ace-High",	//AQT96
        "Ace-High",	//AQT95
        "Ace-High",	//AQT94
        "Ace-High",	//AQT93
        "Ace-High",	//AQT92
        "Ace-High",	//AQT87
        "Ace-High",	//AQT86
        "Ace-High",	//AQT85
        "Ace-High",	//AQT84
        "Ace-High",	//AQT83
        "Ace-High",	//AQT82
        "Ace-High",	//AQT76
        "Ace-High",	//AQT75
        "Ace-High",	//AQT74
        "Ace-High",	//AQT73
        "Ace-High",	//AQT72
        "Ace-High",	//AQT65
        "Ace-High",	//AQT64
        "Ace-High",	//AQT63
        "Ace-High",	//AQT62
        "Ace-High",	//AQT54
        "Ace-High",	//AQT53
        "Ace-High",	//AQT52
        "Ace-High",	//AQT43
        "Ace-High",	//AQT42
        "Ace-High",	//AQT32
        "Ace-High",	//AQ987
        "Ace-High",	//AQ986
        "Ace-High",	//AQ985
        "Ace-High",	//AQ984
        "Ace-High",	//AQ983
        "Ace-High",	//AQ982
        "Ace-High",	//AQ976
        "Ace-High",	//AQ975
        "Ace-High",	//AQ974
        "Ace-High",	//AQ973
        "Ace-High",	//AQ972
        "Ace-High",	//AQ965
        "Ace-High",	//AQ964
        "Ace-High",	//AQ963
        "Ace-High",	//AQ962
        "Ace-High",	//AQ954
        "Ace-High",	//AQ953
        "Ace-High",	//AQ952
        "Ace-High",	//AQ943
        "Ace-High",	//AQ942
        "Ace-High",	//AQ932
        "Ace-High",	//AQ876
        "Ace-High",	//AQ875
        "Ace-High",	//AQ874
        "Ace-High",	//AQ873
        "Ace-High",	//AQ872
        "Ace-High",	//AQ865
        "Ace-High",	//AQ864
        "Ace-High",	//AQ863
        "Ace-High",	//AQ862
        "Ace-High",	//AQ854
        "Ace-High",	//AQ853
        "Ace-High",	//AQ852
        "Ace-High",	//AQ843
        "Ace-High",	//AQ842
        "Ace-High",	//AQ832
        "Ace-High",	//AQ765
        "Ace-High",	//AQ764
        "Ace-High",	//AQ763
        "Ace-High",	//AQ762
        "Ace-High",	//AQ754
        "Ace-High",	//AQ753
        "Ace-High",	//AQ752
        "Ace-High",	//AQ743
        "Ace-High",	//AQ742
        "Ace-High",	//AQ732
        "Ace-High",	//AQ654
        "Ace-High",	//AQ653
        "Ace-High",	//AQ652
        "Ace-High",	//AQ643
        "Ace-High",	//AQ642
        "Ace-High",	//AQ632
        "Ace-High",	//AQ543
        "Ace-High",	//AQ542
        "Ace-High",	//AQ532
        "Ace-High",	//AQ432
        "Ace-High",	//AJT98
        "Ace-High",	//AJT97
        "Ace-High",	//AJT96
        "Ace-High",	//AJT95
        "Ace-High",	//AJT94
        "Ace-High",	//AJT93
        "Ace-High",	//AJT92
        "Ace-High",	//AJT87
        "Ace-High",	//AJT86
        "Ace-High",	//AJT85
        "Ace-High",	//AJT84
        "Ace-High",	//AJT83
        "Ace-High",	//AJT82
        "Ace-High",	//AJT76
        "Ace-High",	//AJT75
        "Ace-High",	//AJT74
        "Ace-High",	//AJT73
        "Ace-High",	//AJT72
        "Ace-High",	//AJT65
        "Ace-High",	//AJT64
        "Ace-High",	//AJT63
        "Ace-High",	//AJT62
        "Ace-High",	//AJT54
        "Ace-High",	//AJT53
        "Ace-High",	//AJT52
        "Ace-High",	//AJT43
        "Ace-High",	//AJT42
        "Ace-High",	//AJT32
        "Ace-High",	//AJ987
        "Ace-High",	//AJ986
        "Ace-High",	//AJ985
        "Ace-High",	//AJ984
        "Ace-High",	//AJ983
        "Ace-High",	//AJ982
        "Ace-High",	//AJ976
        "Ace-High",	//AJ975
        "Ace-High",	//AJ974
        "Ace-High",	//AJ973
        "Ace-High",	//AJ972
        "Ace-High",	//AJ965
        "Ace-High",	//AJ964
        "Ace-High",	//AJ963
        "Ace-High",	//AJ962
        "Ace-High",	//AJ954
        "Ace-High",	//AJ953
        "Ace-High",	//AJ952
        "Ace-High",	//AJ943
        "Ace-High",	//AJ942
        "Ace-High",	//AJ932
        "Ace-High",	//AJ876
        "Ace-High",	//AJ875
        "Ace-High",	//AJ874
        "Ace-High",	//AJ873
        "Ace-High",	//AJ872
        "Ace-High",	//AJ865
        "Ace-High",	//AJ864
        "Ace-High",	//AJ863
        "Ace-High",	//AJ862
        "Ace-High",	//AJ854
        "Ace-High",	//AJ853
        "Ace-High",	//AJ852
        "Ace-High",	//AJ843
        "Ace-High",	//AJ842
        "Ace-High",	//AJ832
        "Ace-High",	//AJ765
        "Ace-High",	//AJ764
        "Ace-High",	//AJ763
        "Ace-High",	//AJ762
        "Ace-High",	//AJ754
        "Ace-High",	//AJ753
        "Ace-High",	//AJ752
        "Ace-High",	//AJ743
        "Ace-High",	//AJ742
        "Ace-High",	//AJ732
        "Ace-High",	//AJ654
        "Ace-High",	//AJ653
        "Ace-High",	//AJ652
        "Ace-High",	//AJ643
        "Ace-High",	//AJ642
        "Ace-High",	//AJ632
        "Ace-High",	//AJ543
        "Ace-High",	//AJ542
        "Ace-High",	//AJ532
        "Ace-High",	//AJ432
        "Ace-High",	//AT987
        "Ace-High",	//AT986
        "Ace-High",	//AT985
        "Ace-High",	//AT984
        "Ace-High",	//AT983
        "Ace-High",	//AT982
        "Ace-High",	//AT976
        "Ace-High",	//AT975
        "Ace-High",	//AT974
        "Ace-High",	//AT973
        "Ace-High",	//AT972
        "Ace-High",	//AT965
        "Ace-High",	//AT964
        "Ace-High",	//AT963
        "Ace-High",	//AT962
        "Ace-High",	//AT954
        "Ace-High",	//AT953
        "Ace-High",	//AT952
        "Ace-High",	//AT943
        "Ace-High",	//AT942
        "Ace-High",	//AT932
        "Ace-High",	//AT876
        "Ace-High",	//AT875
        "Ace-High",	//AT874
        "Ace-High",	//AT873
        "Ace-High",	//AT872
        "Ace-High",	//AT865
        "Ace-High",	//AT864
        "Ace-High",	//AT863
        "Ace-High",	//AT862
        "Ace-High",	//AT854
        "Ace-High",	//AT853
        "Ace-High",	//AT852
        "Ace-High",	//AT843
        "Ace-High",	//AT842
        "Ace-High",	//AT832
        "Ace-High",	//AT765
        "Ace-High",	//AT764
        "Ace-High",	//AT763
        "Ace-High",	//AT762
        "Ace-High",	//AT754
        "Ace-High",	//AT753
        "Ace-High",	//AT752
        "Ace-High",	//AT743
        "Ace-High",	//AT742
        "Ace-High",	//AT732
        "Ace-High",	//AT654
        "Ace-High",	//AT653
        "Ace-High",	//AT652
        "Ace-High",	//AT643
        "Ace-High",	//AT642
        "Ace-High",	//AT632
        "Ace-High",	//AT543
        "Ace-High",	//AT542
        "Ace-High",	//AT532
        "Ace-High",	//AT432
        "Ace-High",	//A9876
        "Ace-High",	//A9875
        "Ace-High",	//A9874
        "Ace-High",	//A9873
        "Ace-High",	//A9872
        "Ace-High",	//A9865
        "Ace-High",	//A9864
        "Ace-High",	//A9863
        "Ace-High",	//A9862
        "Ace-High",	//A9854
        "Ace-High",	//A9853
        "Ace-High",	//A9852
        "Ace-High",	//A9843
        "Ace-High",	//A9842
        "Ace-High",	//A9832
        "Ace-High",	//A9765
        "Ace-High",	//A9764
        "Ace-High",	//A9763
        "Ace-High",	//A9762
        "Ace-High",	//A9754
        "Ace-High",	//A9753
        "Ace-High",	//A9752
        "Ace-High",	//A9743
        "Ace-High",	//A9742
        "Ace-High",	//A9732
        "Ace-High",	//A9654
        "Ace-High",	//A9653
        "Ace-High",	//A9652
        "Ace-High",	//A9643
        "Ace-High",	//A9642
        "Ace-High",	//A9632
        "Ace-High",	//A9543
        "Ace-High",	//A9542
        "Ace-High",	//A9532
        "Ace-High",	//A9432
        "Ace-High",	//A8765
        "Ace-High",	//A8764
        "Ace-High",	//A8763
        "Ace-High",	//A8762
        "Ace-High",	//A8754
        "Ace-High",	//A8753
        "Ace-High",	//A8752
        "Ace-High",	//A8743
        "Ace-High",	//A8742
        "Ace-High",	//A8732
        "Ace-High",	//A8654
        "Ace-High",	//A8653
        "Ace-High",	//A8652
        "Ace-High",	//A8643
        "Ace-High",	//A8642
        "Ace-High",	//A8632
        "Ace-High",	//A8543
        "Ace-High",	//A8542
        "Ace-High",	//A8532
        "Ace-High",	//A8432
        "Ace-High",	//A7654
        "Ace-High",	//A7653
        "Ace-High",	//A7652
        "Ace-High",	//A7643
        "Ace-High",	//A7642
        "Ace-High",	//A7632
        "Ace-High",	//A7543
        "Ace-High",	//A7542
        "Ace-High",	//A7532
        "Ace-High",	//A7432
        "Ace-High",	//A6543
        "Ace-High",	//A6542
        "Ace-High",	//A6532
        "Ace-High",	//A6432
        "King-High",	//KQJT8
        "King-High",	//KQJT7
        "King-High",	//KQJT6
        "King-High",	//KQJT5
        "King-High",	//KQJT4
        "King-High",	//KQJT3
        "King-High",	//KQJT2
        "King-High",	//KQJ98
        "King-High",	//KQJ97
        "King-High",	//KQJ96
        "King-High",	//KQJ95
        "King-High",	//KQJ94
        "King-High",	//KQJ93
        "King-High",	//KQJ92
        "King-High",	//KQJ87
        "King-High",	//KQJ86
        "King-High",	//KQJ85
        "King-High",	//KQJ84
        "King-High",	//KQJ83
        "King-High",	//KQJ82
        "King-High",	//KQJ76
        "King-High",	//KQJ75
        "King-High",	//KQJ74
        "King-High",	//KQJ73
        "King-High",	//KQJ72
        "King-High",	//KQJ65
        "King-High",	//KQJ64
        "King-High",	//KQJ63
        "King-High",	//KQJ62
        "King-High",	//KQJ54
        "King-High",	//KQJ53
        "King-High",	//KQJ52
        "King-High",	//KQJ43
        "King-High",	//KQJ42
        "King-High",	//KQJ32
        "King-High",	//KQT98
        "King-High",	//KQT97
        "King-High",	//KQT96
        "King-High",	//KQT95
        "King-High",	//KQT94
        "King-High",	//KQT93
        "King-High",	//KQT92
        "King-High",	//KQT87
        "King-High",	//KQT86
        "King-High",	//KQT85
        "King-High",	//KQT84
        "King-High",	//KQT83
        "King-High",	//KQT82
        "King-High",	//KQT76
        "King-High",	//KQT75
        "King-High",	//KQT74
        "King-High",	//KQT73
        "King-High",	//KQT72
        "King-High",	//KQT65
        "King-High",	//KQT64
        "King-High",	//KQT63
        "King-High",	//KQT62
        "King-High",	//KQT54
        "King-High",	//KQT53
        "King-High",	//KQT52
        "King-High",	//KQT43
        "King-High",	//KQT42
        "King-High",	//KQT32
        "King-High",	//KQ987
        "King-High",	//KQ986
        "King-High",	//KQ985
        "King-High",	//KQ984
        "King-High",	//KQ983
        "King-High",	//KQ982
        "King-High",	//KQ976
        "King-High",	//KQ975
        "King-High",	//KQ974
        "King-High",	//KQ973
        "King-High",	//KQ972
        "King-High",	//KQ965
        "King-High",	//KQ964
        "King-High",	//KQ963
        "King-High",	//KQ962
        "King-High",	//KQ954
        "King-High",	//KQ953
        "King-High",	//KQ952
        "King-High",	//KQ943
        "King-High",	//KQ942
        "King-High",	//KQ932
        "King-High",	//KQ876
        "King-High",	//KQ875
        "King-High",	//KQ874
        "King-High",	//KQ873
        "King-High",	//KQ872
        "King-High",	//KQ865
        "King-High",	//KQ864
        "King-High",	//KQ863
        "King-High",	//KQ862
        "King-High",	//KQ854
        "King-High",	//KQ853
        "King-High",	//KQ852
        "King-High",	//KQ843
        "King-High",	//KQ842
        "King-High",	//KQ832
        "King-High",	//KQ765
        "King-High",	//KQ764
        "King-High",	//KQ763
        "King-High",	//KQ762
        "King-High",	//KQ754
        "King-High",	//KQ753
        "King-High",	//KQ752
        "King-High",	//KQ743
        "King-High",	//KQ742
        "King-High",	//KQ732
        "King-High",	//KQ654
        "King-High",	//KQ653
        "King-High",	//KQ652
        "King-High",	//KQ643
        "King-High",	//KQ642
        "King-High",	//KQ632
        "King-High",	//KQ543
        "King-High",	//KQ542
        "King-High",	//KQ532
        "King-High",	//KQ432
        "King-High",	//KJT98
        "King-High",	//KJT97
        "King-High",	//KJT96
        "King-High",	//KJT95
        "King-High",	//KJT94
        "King-High",	//KJT93
        "King-High",	//KJT92
        "King-High",	//KJT87
        "King-High",	//KJT86
        "King-High",	//KJT85
        "King-High",	//KJT84
        "King-High",	//KJT83
        "King-High",	//KJT82
        "King-High",	//KJT76
        "King-High",	//KJT75
        "King-High",	//KJT74
        "King-High",	//KJT73
        "King-High",	//KJT72
        "King-High",	//KJT65
        "King-High",	//KJT64
        "King-High",	//KJT63
        "King-High",	//KJT62
        "King-High",	//KJT54
        "King-High",	//KJT53
        "King-High",	//KJT52
        "King-High",	//KJT43
        "King-High",	//KJT42
        "King-High",	//KJT32
        "King-High",	//KJ987
        "King-High",	//KJ986
        "King-High",	//KJ985
        "King-High",	//KJ984
        "King-High",	//KJ983
        "King-High",	//KJ982
        "King-High",	//KJ976
        "King-High",	//KJ975
        "King-High",	//KJ974
        "King-High",	//KJ973
        "King-High",	//KJ972
        "King-High",	//KJ965
        "King-High",	//KJ964
        "King-High",	//KJ963
        "King-High",	//KJ962
        "King-High",	//KJ954
        "King-High",	//KJ953
        "King-High",	//KJ952
        "King-High",	//KJ943
        "King-High",	//KJ942
        "King-High",	//KJ932
        "King-High",	//KJ876
        "King-High",	//KJ875
        "King-High",	//KJ874
        "King-High",	//KJ873
        "King-High",	//KJ872
        "King-High",	//KJ865
        "King-High",	//KJ864
        "King-High",	//KJ863
        "King-High",	//KJ862
        "King-High",	//KJ854
        "King-High",	//KJ853
        "King-High",	//KJ852
        "King-High",	//KJ843
        "King-High",	//KJ842
        "King-High",	//KJ832
        "King-High",	//KJ765
        "King-High",	//KJ764
        "King-High",	//KJ763
        "King-High",	//KJ762
        "King-High",	//KJ754
        "King-High",	//KJ753
        "King-High",	//KJ752
        "King-High",	//KJ743
        "King-High",	//KJ742
        "King-High",	//KJ732
        "King-High",	//KJ654
        "King-High",	//KJ653
        "King-High",	//KJ652
        "King-High",	//KJ643
        "King-High",	//KJ642
        "King-High",	//KJ632
        "King-High",	//KJ543
        "King-High",	//KJ542
        "King-High",	//KJ532
        "King-High",	//KJ432
        "King-High",	//KT987
        "King-High",	//KT986
        "King-High",	//KT985
        "King-High",	//KT984
        "King-High",	//KT983
        "King-High",	//KT982
        "King-High",	//KT976
        "King-High",	//KT975
        "King-High",	//KT974
        "King-High",	//KT973
        "King-High",	//KT972
        "King-High",	//KT965
        "King-High",	//KT964
        "King-High",	//KT963
        "King-High",	//KT962
        "King-High",	//KT954
        "King-High",	//KT953
        "King-High",	//KT952
        "King-High",	//KT943
        "King-High",	//KT942
        "King-High",	//KT932
        "King-High",	//KT876
        "King-High",	//KT875
        "King-High",	//KT874
        "King-High",	//KT873
        "King-High",	//KT872
        "King-High",	//KT865
        "King-High",	//KT864
        "King-High",	//KT863
        "King-High",	//KT862
        "King-High",	//KT854
        "King-High",	//KT853
        "King-High",	//KT852
        "King-High",	//KT843
        "King-High",	//KT842
        "King-High",	//KT832
        "King-High",	//KT765
        "King-High",	//KT764
        "King-High",	//KT763
        "King-High",	//KT762
        "King-High",	//KT754
        "King-High",	//KT753
        "King-High",	//KT752
        "King-High",	//KT743
        "King-High",	//KT742
        "King-High",	//KT732
        "King-High",	//KT654
        "King-High",	//KT653
        "King-High",	//KT652
        "King-High",	//KT643
        "King-High",	//KT642
        "King-High",	//KT632
        "King-High",	//KT543
        "King-High",	//KT542
        "King-High",	//KT532
        "King-High",	//KT432
        "King-High",	//K9876
        "King-High",	//K9875
        "King-High",	//K9874
        "King-High",	//K9873
        "King-High",	//K9872
        "King-High",	//K9865
        "King-High",	//K9864
        "King-High",	//K9863
        "King-High",	//K9862
        "King-High",	//K9854
        "King-High",	//K9853
        "King-High",	//K9852
        "King-High",	//K9843
        "King-High",	//K9842
        "King-High",	//K9832
        "King-High",	//K9765
        "King-High",	//K9764
        "King-High",	//K9763
        "King-High",	//K9762
        "King-High",	//K9754
        "King-High",	//K9753
        "King-High",	//K9752
        "King-High",	//K9743
        "King-High",	//K9742
        "King-High",	//K9732
        "King-High",	//K9654
        "King-High",	//K9653
        "King-High",	//K9652
        "King-High",	//K9643
        "King-High",	//K9642
        "King-High",	//K9632
        "King-High",	//K9543
        "King-High",	//K9542
        "King-High",	//K9532
        "King-High",	//K9432
        "King-High",	//K8765
        "King-High",	//K8764
        "King-High",	//K8763
        "King-High",	//K8762
        "King-High",	//K8754
        "King-High",	//K8753
        "King-High",	//K8752
        "King-High",	//K8743
        "King-High",	//K8742
        "King-High",	//K8732
        "King-High",	//K8654
        "King-High",	//K8653
        "King-High",	//K8652
        "King-High",	//K8643
        "King-High",	//K8642
        "King-High",	//K8632
        "King-High",	//K8543
        "King-High",	//K8542
        "King-High",	//K8532
        "King-High",	//K8432
        "King-High",	//K7654
        "King-High",	//K7653
        "King-High",	//K7652
        "King-High",	//K7643
        "King-High",	//K7642
        "King-High",	//K7632
        "King-High",	//K7543
        "King-High",	//K7542
        "King-High",	//K7532
        "King-High",	//K7432
        "King-High",	//K6543
        "King-High",	//K6542
        "King-High",	//K6532
        "King-High",	//K6432
        "King-High",	//K5432
        "Queen-High",	//QJT97
        "Queen-High",	//QJT96
        "Queen-High",	//QJT95
        "Queen-High",	//QJT94
        "Queen-High",	//QJT93
        "Queen-High",	//QJT92
        "Queen-High",	//QJT87
        "Queen-High",	//QJT86
        "Queen-High",	//QJT85
        "Queen-High",	//QJT84
        "Queen-High",	//QJT83
        "Queen-High",	//QJT82
        "Queen-High",	//QJT76
        "Queen-High",	//QJT75
        "Queen-High",	//QJT74
        "Queen-High",	//QJT73
        "Queen-High",	//QJT72
        "Queen-High",	//QJT65
        "Queen-High",	//QJT64
        "Queen-High",	//QJT63
        "Queen-High",	//QJT62
        "Queen-High",	//QJT54
        "Queen-High",	//QJT53
        "Queen-High",	//QJT52
        "Queen-High",	//QJT43
        "Queen-High",	//QJT42
        "Queen-High",	//QJT32
        "Queen-High",	//QJ987
        "Queen-High",	//QJ986
        "Queen-High",	//QJ985
        "Queen-High",	//QJ984
        "Queen-High",	//QJ983
        "Queen-High",	//QJ982
        "Queen-High",	//QJ976
        "Queen-High",	//QJ975
        "Queen-High",	//QJ974
        "Queen-High",	//QJ973
        "Queen-High",	//QJ972
        "Queen-High",	//QJ965
        "Queen-High",	//QJ964
        "Queen-High",	//QJ963
        "Queen-High",	//QJ962
        "Queen-High",	//QJ954
        "Queen-High",	//QJ953
        "Queen-High",	//QJ952
        "Queen-High",	//QJ943
        "Queen-High",	//QJ942
        "Queen-High",	//QJ932
        "Queen-High",	//QJ876
        "Queen-High",	//QJ875
        "Queen-High",	//QJ874
        "Queen-High",	//QJ873
        "Queen-High",	//QJ872
        "Queen-High",	//QJ865
        "Queen-High",	//QJ864
        "Queen-High",	//QJ863
        "Queen-High",	//QJ862
        "Queen-High",	//QJ854
        "Queen-High",	//QJ853
        "Queen-High",	//QJ852
        "Queen-High",	//QJ843
        "Queen-High",	//QJ842
        "Queen-High",	//QJ832
        "Queen-High",	//QJ765
        "Queen-High",	//QJ764
        "Queen-High",	//QJ763
        "Queen-High",	//QJ762
        "Queen-High",	//QJ754
        "Queen-High",	//QJ753
        "Queen-High",	//QJ752
        "Queen-High",	//QJ743
        "Queen-High",	//QJ742
        "Queen-High",	//QJ732
        "Queen-High",	//QJ654
        "Queen-High",	//QJ653
        "Queen-High",	//QJ652
        "Queen-High",	//QJ643
        "Queen-High",	//QJ642
        "Queen-High",	//QJ632
        "Queen-High",	//QJ543
        "Queen-High",	//QJ542
        "Queen-High",	//QJ532
        "Queen-High",	//QJ432
        "Queen-High",	//QT987
        "Queen-High",	//QT986
        "Queen-High",	//QT985
        "Queen-High",	//QT984
        "Queen-High",	//QT983
        "Queen-High",	//QT982
        "Queen-High",	//QT976
        "Queen-High",	//QT975
        "Queen-High",	//QT974
        "Queen-High",	//QT973
        "Queen-High",	//QT972
        "Queen-High",	//QT965
        "Queen-High",	//QT964
        "Queen-High",	//QT963
        "Queen-High",	//QT962
        "Queen-High",	//QT954
        "Queen-High",	//QT953
        "Queen-High",	//QT952
        "Queen-High",	//QT943
        "Queen-High",	//QT942
        "Queen-High",	//QT932
        "Queen-High",	//QT876
        "Queen-High",	//QT875
        "Queen-High",	//QT874
        "Queen-High",	//QT873
        "Queen-High",	//QT872
        "Queen-High",	//QT865
        "Queen-High",	//QT864
        "Queen-High",	//QT863
        "Queen-High",	//QT862
        "Queen-High",	//QT854
        "Queen-High",	//QT853
        "Queen-High",	//QT852
        "Queen-High",	//QT843
        "Queen-High",	//QT842
        "Queen-High",	//QT832
        "Queen-High",	//QT765
        "Queen-High",	//QT764
        "Queen-High",	//QT763
        "Queen-High",	//QT762
        "Queen-High",	//QT754
        "Queen-High",	//QT753
        "Queen-High",	//QT752
        "Queen-High",	//QT743
        "Queen-High",	//QT742
        "Queen-High",	//QT732
        "Queen-High",	//QT654
        "Queen-High",	//QT653
        "Queen-High",	//QT652
        "Queen-High",	//QT643
        "Queen-High",	//QT642
        "Queen-High",	//QT632
        "Queen-High",	//QT543
        "Queen-High",	//QT542
        "Queen-High",	//QT532
        "Queen-High",	//QT432
        "Queen-High",	//Q9876
        "Queen-High",	//Q9875
        "Queen-High",	//Q9874
        "Queen-High",	//Q9873
        "Queen-High",	//Q9872
        "Queen-High",	//Q9865
        "Queen-High",	//Q9864
        "Queen-High",	//Q9863
        "Queen-High",	//Q9862
        "Queen-High",	//Q9854
        "Queen-High",	//Q9853
        "Queen-High",	//Q9852
        "Queen-High",	//Q9843
        "Queen-High",	//Q9842
        "Queen-High",	//Q9832
        "Queen-High",	//Q9765
        "Queen-High",	//Q9764
        "Queen-High",	//Q9763
        "Queen-High",	//Q9762
        "Queen-High",	//Q9754
        "Queen-High",	//Q9753
        "Queen-High",	//Q9752
        "Queen-High",	//Q9743
        "Queen-High",	//Q9742
        "Queen-High",	//Q9732
        "Queen-High",	//Q9654
        "Queen-High",	//Q9653
        "Queen-High",	//Q9652
        "Queen-High",	//Q9643
        "Queen-High",	//Q9642
        "Queen-High",	//Q9632
        "Queen-High",	//Q9543
        "Queen-High",	//Q9542
        "Queen-High",	//Q9532
        "Queen-High",	//Q9432
        "Queen-High",	//Q8765
        "Queen-High",	//Q8764
        "Queen-High",	//Q8763
        "Queen-High",	//Q8762
        "Queen-High",	//Q8754
        "Queen-High",	//Q8753
        "Queen-High",	//Q8752
        "Queen-High",	//Q8743
        "Queen-High",	//Q8742
        "Queen-High",	//Q8732
        "Queen-High",	//Q8654
        "Queen-High",	//Q8653
        "Queen-High",	//Q8652
        "Queen-High",	//Q8643
        "Queen-High",	//Q8642
        "Queen-High",	//Q8632
        "Queen-High",	//Q8543
        "Queen-High",	//Q8542
        "Queen-High",	//Q8532
        "Queen-High",	//Q8432
        "Queen-High",	//Q7654
        "Queen-High",	//Q7653
        "Queen-High",	//Q7652
        "Queen-High",	//Q7643
        "Queen-High",	//Q7642
        "Queen-High",	//Q7632
        "Queen-High",	//Q7543
        "Queen-High",	//Q7542
        "Queen-High",	//Q7532
        "Queen-High",	//Q7432
        "Queen-High",	//Q6543
        "Queen-High",	//Q6542
        "Queen-High",	//Q6532
        "Queen-High",	//Q6432
        "Queen-High",	//Q5432
        "Jack-High",	//JT986
        "Jack-High",	//JT985
        "Jack-High",	//JT984
        "Jack-High",	//JT983
        "Jack-High",	//JT982
        "Jack-High",	//JT976
        "Jack-High",	//JT975
        "Jack-High",	//JT974
        "Jack-High",	//JT973
        "Jack-High",	//JT972
        "Jack-High",	//JT965
        "Jack-High",	//JT964
        "Jack-High",	//JT963
        "Jack-High",	//JT962
        "Jack-High",	//JT954
        "Jack-High",	//JT953
        "Jack-High",	//JT952
        "Jack-High",	//JT943
        "Jack-High",	//JT942
        "Jack-High",	//JT932
        "Jack-High",	//JT876
        "Jack-High",	//JT875
        "Jack-High",	//JT874
        "Jack-High",	//JT873
        "Jack-High",	//JT872
        "Jack-High",	//JT865
        "Jack-High",	//JT864
        "Jack-High",	//JT863
        "Jack-High",	//JT862
        "Jack-High",	//JT854
        "Jack-High",	//JT853
        "Jack-High",	//JT852
        "Jack-High",	//JT843
        "Jack-High",	//JT842
        "Jack-High",	//JT832
        "Jack-High",	//JT765
        "Jack-High",	//JT764
        "Jack-High",	//JT763
        "Jack-High",	//JT762
        "Jack-High",	//JT754
        "Jack-High",	//JT753
        "Jack-High",	//JT752
        "Jack-High",	//JT743
        "Jack-High",	//JT742
        "Jack-High",	//JT732
        "Jack-High",	//JT654
        "Jack-High",	//JT653
        "Jack-High",	//JT652
        "Jack-High",	//JT643
        "Jack-High",	//JT642
        "Jack-High",	//JT632
        "Jack-High",	//JT543
        "Jack-High",	//JT542
        "Jack-High",	//JT532
        "Jack-High",	//JT432
        "Jack-High",	//J9876
        "Jack-High",	//J9875
        "Jack-High",	//J9874
        "Jack-High",	//J9873
        "Jack-High",	//J9872
        "Jack-High",	//J9865
        "Jack-High",	//J9864
        "Jack-High",	//J9863
        "Jack-High",	//J9862
        "Jack-High",	//J9854
        "Jack-High",	//J9853
        "Jack-High",	//J9852
        "Jack-High",	//J9843
        "Jack-High",	//J9842
        "Jack-High",	//J9832
        "Jack-High",	//J9765
        "Jack-High",	//J9764
        "Jack-High",	//J9763
        "Jack-High",	//J9762
        "Jack-High",	//J9754
        "Jack-High",	//J9753
        "Jack-High",	//J9752
        "Jack-High",	//J9743
        "Jack-High",	//J9742
        "Jack-High",	//J9732
        "Jack-High",	//J9654
        "Jack-High",	//J9653
        "Jack-High",	//J9652
        "Jack-High",	//J9643
        "Jack-High",	//J9642
        "Jack-High",	//J9632
        "Jack-High",	//J9543
        "Jack-High",	//J9542
        "Jack-High",	//J9532
        "Jack-High",	//J9432
        "Jack-High",	//J8765
        "Jack-High",	//J8764
        "Jack-High",	//J8763
        "Jack-High",	//J8762
        "Jack-High",	//J8754
        "Jack-High",	//J8753
        "Jack-High",	//J8752
        "Jack-High",	//J8743
        "Jack-High",	//J8742
        "Jack-High",	//J8732
        "Jack-High",	//J8654
        "Jack-High",	//J8653
        "Jack-High",	//J8652
        "Jack-High",	//J8643
        "Jack-High",	//J8642
        "Jack-High",	//J8632
        "Jack-High",	//J8543
        "Jack-High",	//J8542
        "Jack-High",	//J8532
        "Jack-High",	//J8432
        "Jack-High",	//J7654
        "Jack-High",	//J7653
        "Jack-High",	//J7652
        "Jack-High",	//J7643
        "Jack-High",	//J7642
        "Jack-High",	//J7632
        "Jack-High",	//J7543
        "Jack-High",	//J7542
        "Jack-High",	//J7532
        "Jack-High",	//J7432
        "Jack-High",	//J6543
        "Jack-High",	//J6542
        "Jack-High",	//J6532
        "Jack-High",	//J6432
        "Jack-High",	//J5432
        "Ten-High",	//T9875
        "Ten-High",	//T9874
        "Ten-High",	//T9873
        "Ten-High",	//T9872
        "Ten-High",	//T9865
        "Ten-High",	//T9864
        "Ten-High",	//T9863
        "Ten-High",	//T9862
        "Ten-High",	//T9854
        "Ten-High",	//T9853
        "Ten-High",	//T9852
        "Ten-High",	//T9843
        "Ten-High",	//T9842
        "Ten-High",	//T9832
        "Ten-High",	//T9765
        "Ten-High",	//T9764
        "Ten-High",	//T9763
        "Ten-High",	//T9762
        "Ten-High",	//T9754
        "Ten-High",	//T9753
        "Ten-High",	//T9752
        "Ten-High",	//T9743
        "Ten-High",	//T9742
        "Ten-High",	//T9732
        "Ten-High",	//T9654
        "Ten-High",	//T9653
        "Ten-High",	//T9652
        "Ten-High",	//T9643
        "Ten-High",	//T9642
        "Ten-High",	//T9632
        "Ten-High",	//T9543
        "Ten-High",	//T9542
        "Ten-High",	//T9532
        "Ten-High",	//T9432
        "Ten-High",	//T8765
        "Ten-High",	//T8764
        "Ten-High",	//T8763
        "Ten-High",	//T8762
        "Ten-High",	//T8754
        "Ten-High",	//T8753
        "Ten-High",	//T8752
        "Ten-High",	//T8743
        "Ten-High",	//T8742
        "Ten-High",	//T8732
        "Ten-High",	//T8654
        "Ten-High",	//T8653
        "Ten-High",	//T8652
        "Ten-High",	//T8643
        "Ten-High",	//T8642
        "Ten-High",	//T8632
        "Ten-High",	//T8543
        "Ten-High",	//T8542
        "Ten-High",	//T8532
        "Ten-High",	//T8432
        "Ten-High",	//T7654
        "Ten-High",	//T7653
        "Ten-High",	//T7652
        "Ten-High",	//T7643
        "Ten-High",	//T7642
        "Ten-High",	//T7632
        "Ten-High",	//T7543
        "Ten-High",	//T7542
        "Ten-High",	//T7532
        "Ten-High",	//T7432
        "Ten-High",	//T6543
        "Ten-High",	//T6542
        "Ten-High",	//T6532
        "Ten-High",	//T6432
        "Ten-High",	//T5432
        "Nine-High",	//98764
        "Nine-High",	//98763
        "Nine-High",	//98762
        "Nine-High",	//98754
        "Nine-High",	//98753
        "Nine-High",	//98752
        "Nine-High",	//98743
        "Nine-High",	//98742
        "Nine-High",	//98732
        "Nine-High",	//98654
        "Nine-High",	//98653
        "Nine-High",	//98652
        "Nine-High",	//98643
        "Nine-High",	//98642
        "Nine-High",	//98632
        "Nine-High",	//98543
        "Nine-High",	//98542
        "Nine-High",	//98532
        "Nine-High",	//98432
        "Nine-High",	//97654
        "Nine-High",	//97653
        "Nine-High",	//97652
        "Nine-High",	//97643
        "Nine-High",	//97642
        "Nine-High",	//97632
        "Nine-High",	//97543
        "Nine-High",	//97542
        "Nine-High",	//97532
        "Nine-High",	//97432
        "Nine-High",	//96543
        "Nine-High",	//96542
        "Nine-High",	//96532
        "Nine-High",	//96432
        "Nine-High",	//95432
        "Eight-High",	//87653
        "Eight-High",	//87652
        "Eight-High",	//87643
        "Eight-High",	//87642
        "Eight-High",	//87632
        "Eight-High",	//87543
        "Eight-High",	//87542
        "Eight-High",	//87532
        "Eight-High",	//87432
        "Eight-High",	//86543
        "Eight-High",	//86542
        "Eight-High",	//86532
        "Eight-High",	//86432
        "Eight-High",	//85432
        "Seven-High",	//76542
        "Seven-High",	//76532
        "Seven-High",	//76432
        "Seven-High",	//75432
    };
}