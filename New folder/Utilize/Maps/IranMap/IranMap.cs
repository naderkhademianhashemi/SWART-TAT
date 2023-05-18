using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Utilize.Maps.IranMap
{
    class IranMap
    {
        #region private variables

        private const int NUM_CONTINENTS = 34;
        private static int SCALE = 1;
        readonly List<Point>[] irContinents = new List<Point>[NUM_CONTINENTS];

        #endregion

        #region GET/SET methods
        public int getScale()
        {
            return SCALE;
        }
        public void SetScale(int Scale)
        {
            SCALE = Scale;
        }


        public int get_nContinents()
        {
            return NUM_CONTINENTS;
        }


        public Point[] get_PolygonPoints(int polyIndex)
        {
            var res = new Point[irContinents[polyIndex].Count];

            irContinents[polyIndex].CopyTo(res);

            return res;
        }


        public double getAngle(Point bP, Point p1, Point p2)
        {
            var v1 = new Point(p2.X - bP.X, p2.Y - bP.Y);

            var v2 = new Point(p1.X - bP.X, p1.Y - bP.Y);

            return Math.Atan2(v1.X * v2.Y - v1.Y * v2.X, v1.X * v2.X + v1.Y * v2.Y);
        }


        public Point get_polygonCenter(int polyIndex)
        {
            int X = 0;
            int Y = 0;

            for (int i = 0; i < irContinents[polyIndex].Count; i++)
            {
                X += irContinents[polyIndex].ElementAt(i).X;
                Y += irContinents[polyIndex].ElementAt(i).Y;
            }
            return new Point(X / irContinents[polyIndex].Count, Y / irContinents[polyIndex].Count);
        }

        public int getContainerPolygon(Point p)
        {
            for (int i = 0; i < NUM_CONTINENTS; i++)
                if (isPointInPolygon(p, i))
                    return i;
            return -1;
        }


        public Point getCentroid(int polyIndex)
        {
            int X = 0;
            int Y = 0;

            double polygon_area = 0;
            var m_Points = new Point[irContinents[polyIndex].Count + 1];

            irContinents[polyIndex].CopyTo(m_Points);
            m_Points[irContinents[polyIndex].Count] = irContinents[polyIndex].ElementAt(0);

            for (int pt = 0; pt < irContinents[polyIndex].Count; pt++)
            {
                double second_factor = m_Points[pt].X * m_Points[pt + 1].Y - m_Points[pt + 1].X * m_Points[pt].Y;
                X += (m_Points[pt].X + m_Points[pt + 1].X) * (int)second_factor;
                Y += (m_Points[pt].Y + m_Points[pt + 1].Y) * (int)second_factor;

                polygon_area += (m_Points[pt + 1].X - m_Points[pt].X) * (m_Points[pt + 1].Y + m_Points[pt].Y) / 2;
            }

            X = X / 6 / (int)polygon_area;
            Y = Y / 6 / (int)polygon_area;
            return new Point(Math.Abs(X), Math.Abs(Y));



        }


        public Color getColor(int polyIndex)
        {
            switch (polyIndex)
            {
                case 0:
                    return Color.LightBlue;
                case 1:
                    return Color.LightPink;
                case 2:
                    return Color.Gold;
                case 3:
                    return Color.LightPink;
                case 4:
                    return Color.LightBlue;
                case 5:
                    return Color.Green;
                case 6:
                    return Color.LightPink;
                case 7:
                    return Color.Wheat;
                case 8:
                    return Color.LightPink;
                case 9:
                    return Color.Green;
                case 10:
                    return Color.LightBlue;
                case 11:
                    return Color.Gold;
                case 12:
                    return Color.LightBlue;
                case 13:
                    return Color.Green;
                case 14:
                    return Color.Gold;
                case 15:
                    return Color.Violet;
                case 16:
                    return Color.Wheat;
                case 17:
                    return Color.YellowGreen;
                case 18:
                    return Color.Violet;
                case 19:
                    return Color.LightPink;
                case 20:
                    return Color.Peru;
                case 21:
                    return Color.LightBlue;
                case 22:
                    return Color.Peru;
                case 23:
                    return Color.Wheat;
                case 24:
                    return Color.Green;
                case 25:
                    return Color.Gold;
                case 26:
                    return Color.LightPink;
                case 28:
                    return Color.Violet;
                case 29:
                    return Color.Wheat;
                default:
                    return Color.Blue;
            }

        }


        public string getName(int polyIndex)
        {
            switch (polyIndex)
            {
                case 0:
                    return "خراسان شمالی";
                case 1:
                    return "خراسان رضوی";
                case 2:
                    return "خراسان جنوبی";
                case 3:
                    return "سیستان و بلوچستان";
                case 4:
                    return "کرمان";
                case 5:
                    return "یزد";
                case 6:
                    return "فارس";
                case 7:
                    return "هرمزگان";
                case 8:
                    return "بوشهر";
                case 9:
                    return "سمنان";
                case 10:
                    return "مازندران";
                case 11:
                    return "گلستان";
                case 12:
                    return "اصفهان";
                case 13:
                    return "قم";
                case 14:
                    return "استان تهران";
                case 15:
                    return "گیلان";
                case 16:
                    return "قزوین";
                case 17:
                    return "چهارمهال و بختیاری";
                case 18:
                    return "بویراحمد";
                case 19:
                    return "خوزستان";
                case 20:
                    return "ایلام";
                case 21:
                    return "کرمانشاه";
                case 22:
                    return "لرستان";
                case 23:
                    return "مرکزی";
                case 24:
                    return "همدان";
                case 25:
                    return "کردستان";
                case 26:
                    return "زنجان";
                case 27:
                    return "آذربایجان غربی";
                case 28:
                    return "آذربایجان شرقی";
                case 29:
                    return "اردبیل";
                case 30:
                    return "دریا خزر";
                case 31:
                    return "خلیج فارس";
                case 32:
                    return "تهران بزرگ";
                case 33:
                    return "کیش";
                case 36:
                    return "کیش";
                default:
                    return "";
            }
        }


        public int getStateID(int polyIndex)
        {
            switch (polyIndex)
            {
                case 0:
                    return 30;
                case 1:
                    return 2;
                case 2:
                    return 31;
                case 3:
                    return 23;
                case 4:
                    return 6;
                case 5:
                    return 20;
                case 6:
                    return 9;
                case 7:
                    return 25;
                case 8:
                    return 11;
                case 9:
                    return 16;
                case 10:
                    return 4;
                case 11:
                    return 28;
                case 12:
                    return 21;
                case 13:
                    return 14;
                case 14:
                    return 29;
                case 15:
                    return 13;
                case 16:
                    return 26;
                case 17:
                    return 22;
                case 18:
                    return 10;
                case 19:
                    return 15;
                case 20:
                    return 8;
                case 21:
                    return 19;
                case 22:
                    return 12;
                case 23:
                    return 5;
                case 24:
                    return 3;
                case 25:
                    return 24;
                case 26:
                    return 27;
                case 27:
                    return 7;
                case 28:
                    return 17;
                case 29:
                    return 18;
                case 30:
                    return -1;
                case 31:
                    return -1;
                case 32:
                    return 1;
                case 33:
                    return 33;
                case 36:
                    return 36;
                default:
                    return -1;
            }
        }

        #endregion


        #region methods

        public bool isPointInPolygon(Point point, int polyIndex)
        {
            int maxPoint = irContinents[polyIndex].Count - 1;

            double totalAngle = getAngle(point, irContinents[polyIndex].ElementAt(maxPoint), irContinents[polyIndex].ElementAt(0));

            for (int i = 0; i < maxPoint; i++)
                totalAngle += getAngle(point, irContinents[polyIndex].ElementAt(i), irContinents[polyIndex].ElementAt(i + 1));
            return (Math.Abs(totalAngle) > 0.000001);
        }


        public int groupId2Index(int groupId)
        {
            switch (groupId)
            {
                case 1:
                    return 32;
                case 2:
                    return 1;
                case 3:
                    return 24;
                case 4:
                    return 10;
                case 5:
                    return 23;
                case 6:
                    return 4;
                case 7:
                    return 27;
                case 8:
                    return 20;
                case 9:
                    return 6;
                case 10:
                    return 18;
                case 11:
                    return 8;
                case 12:
                    return 22;
                case 13:
                    return 15;
                case 14:
                    return 13;
                case 15:
                    return 19;
                case 16:
                    return 9;
                case 17:
                    return 28;
                case 18:
                    return 29;
                case 19:
                    return 21;
                case 20:
                    return 5;
                case 21:
                    return 12;
                case 22:
                    return 17;
                case 23:
                    return 3;
                case 24:
                    return 25;
                case 25:
                    return 7;
                case 26:
                    return 16;
                case 27:
                    return 26;
                case 28:
                    return 11;
                case 29:
                    return 14;
                case 30:
                    return 0;
                case 31:
                    return 2;
                case 33:
                    return 33;
                case 36:
                    return 36;
                default:
                    return -1;
            }
        }

        public IranMap()
        {
            irContinents[0] = new List<Point>
                                  {
                                      new Point(474/SCALE, 125/SCALE),
                                      new Point(476/SCALE, 119/SCALE),
                                      new Point(471/SCALE, 114/SCALE),
                                      new Point(463/SCALE, 117/SCALE),
                                      new Point(447/SCALE, 108/SCALE),
                                      new Point(444/SCALE, 102/SCALE),
                                      new Point(446/SCALE, 96/SCALE),
                                      new Point(437/SCALE, 89/SCALE),
                                      new Point(436/SCALE, 90/SCALE),
                                      new Point(438/SCALE, 84/SCALE),
                                      new Point(449/SCALE, 78/SCALE),
                                      new Point(449/SCALE, 71/SCALE),
                                      new Point(445/SCALE, 65/SCALE),
                                      new Point(446/SCALE, 48/SCALE),
                                      new Point(443/SCALE, 43/SCALE),
                                      new Point(445/SCALE, 38/SCALE),
                                      new Point(455/SCALE, 32/SCALE),
                                      new Point(465/SCALE, 35/SCALE),
                                      new Point(474/SCALE, 31/SCALE),
                                      new Point(481/SCALE, 37/SCALE),
                                      new Point(481/SCALE, 42/SCALE),
                                      new Point(493/SCALE, 42/SCALE),
                                      new Point(505/SCALE, 47/SCALE),
                                      new Point(513/SCALE, 46/SCALE),
                                      new Point(515/SCALE, 50/SCALE),
                                      new Point(523/SCALE, 52/SCALE),
                                      new Point(526/SCALE, 48/SCALE),
                                      new Point(532/SCALE, 51/SCALE),
                                      new Point(535/SCALE, 46/SCALE),
                                      new Point(547/SCALE, 50/SCALE),
                                      new Point(554/SCALE, 50/SCALE),
                                      new Point(559/SCALE, 56/SCALE),
                                      new Point(557/SCALE, 59/SCALE),
                                      new Point(561/SCALE, 61/SCALE),
                                      new Point(568/SCALE, 67/SCALE),
                                      new Point(567/SCALE, 82/SCALE),
                                      new Point(555/SCALE, 86/SCALE),
                                      new Point(554/SCALE, 101/SCALE),
                                      new Point(550/SCALE, 109/SCALE),
                                      new Point(507/SCALE, 107/SCALE),
                                      new Point(473/SCALE, 125/SCALE)
                                  };
            irContinents[1] = new List<Point>
                                  {
                                      new Point(637/SCALE, 237/SCALE),
                                      new Point(599/SCALE, 267/SCALE),
                                      new Point(570/SCALE, 264/SCALE),
                                      new Point(562/SCALE, 273/SCALE),
                                      new Point(549/SCALE, 270/SCALE),
                                      new Point(539/SCALE, 281/SCALE),
                                      new Point(524/SCALE, 264/SCALE),
                                      new Point(516/SCALE, 269/SCALE),
                                      new Point(515/SCALE, 281/SCALE),
                                      new Point(500/SCALE, 291/SCALE),
                                      new Point(481/SCALE, 288/SCALE),
                                      new Point(473/SCALE, 279/SCALE),
                                      new Point(457/SCALE, 275/SCALE),
                                      new Point(441/SCALE, 260/SCALE),
                                      new Point(440/SCALE, 219/SCALE),
                                      new Point(455/SCALE, 218/SCALE),
                                      new Point(469/SCALE, 188/SCALE),
                                      new Point(488/SCALE, 173/SCALE),
                                      new Point(489/SCALE, 162/SCALE),
                                      new Point(493/SCALE, 156/SCALE),
                                      new Point(479/SCALE, 146/SCALE),
                                      new Point(472/SCALE, 132/SCALE),
                                      new Point(473/SCALE, 125/SCALE),
                                      new Point(507/SCALE, 107/SCALE),
                                      new Point(550/SCALE, 109/SCALE),
                                      new Point(554/SCALE, 101/SCALE),
                                      new Point(555/SCALE, 86/SCALE),
                                      new Point(567/SCALE, 82/SCALE),
                                      new Point(568/SCALE, 67/SCALE),
                                      new Point(581/SCALE, 68/SCALE),
                                      new Point(597/SCALE, 79/SCALE),
                                      new Point(597/SCALE, 83/SCALE),
                                      new Point(608/SCALE, 82/SCALE),
                                      new Point(614/SCALE, 78/SCALE),
                                      new Point(623/SCALE, 78/SCALE),
                                      new Point(627/SCALE, 74/SCALE),
                                      new Point(629/SCALE, 90/SCALE),
                                      new Point(634/SCALE, 100/SCALE),
                                      new Point(630/SCALE, 105/SCALE),
                                      new Point(638/SCALE, 113/SCALE),
                                      new Point(638/SCALE, 120/SCALE),
                                      new Point(642/SCALE, 126/SCALE),
                                      new Point(638/SCALE, 138/SCALE),
                                      new Point(639/SCALE, 144/SCALE),
                                      new Point(637/SCALE, 149/SCALE),
                                      new Point(638/SCALE, 165/SCALE),
                                      new Point(631/SCALE, 173/SCALE),
                                      new Point(639/SCALE, 181/SCALE),
                                      new Point(630/SCALE, 184/SCALE),
                                      new Point(626/SCALE, 191/SCALE),
                                      new Point(625/SCALE, 198/SCALE),
                                      new Point(631/SCALE, 209/SCALE),
                                      new Point(630/SCALE, 214/SCALE),
                                      new Point(636/SCALE, 216/SCALE),
                                      new Point(647/SCALE, 214/SCALE),
                                      new Point(645/SCALE, 223/SCALE)
                                  };
            irContinents[2] = new List<Point>
                                  {
                                      new Point(637/SCALE, 237/SCALE),
                                      new Point(655/SCALE, 275/SCALE),
                                      new Point(652/SCALE, 282/SCALE),
                                      new Point(660/SCALE, 303/SCALE),
                                      new Point(664/SCALE, 314/SCALE),
                                      new Point(652/SCALE, 325/SCALE),
                                      new Point(636/SCALE, 334/SCALE),
                                      new Point(612/SCALE, 352/SCALE),
                                      new Point(598/SCALE, 337/SCALE),
                                      new Point(498/SCALE, 311/SCALE),
                                      new Point(481/SCALE, 288/SCALE),
                                      new Point(500/SCALE, 291/SCALE),
                                      new Point(515/SCALE, 281/SCALE),
                                      new Point(516/SCALE, 269/SCALE),
                                      new Point(524/SCALE, 264/SCALE),
                                      new Point(539/SCALE, 281/SCALE),
                                      new Point(549/SCALE, 270/SCALE),
                                      new Point(562/SCALE, 273/SCALE),
                                      new Point(570/SCALE, 264/SCALE),
                                      new Point(599/SCALE, 267/SCALE)
                                  };
            irContinents[3] = new List<Point>
                                  {
                                      new Point(619/SCALE, 533/SCALE),
                                      new Point(622/SCALE, 529/SCALE),
                                      new Point(613/SCALE, 516/SCALE),
                                      new Point(613/SCALE, 511/SCALE),
                                      new Point(618/SCALE, 492/SCALE),
                                      new Point(614/SCALE, 491/SCALE),
                                      new Point(609/SCALE, 468/SCALE),
                                      new Point(617/SCALE, 460/SCALE),
                                      new Point(608/SCALE, 453/SCALE),
                                      new Point(625/SCALE, 439/SCALE),
                                      new Point(620/SCALE, 425/SCALE),
                                      new Point(625/SCALE, 416/SCALE),
                                      new Point(620/SCALE, 401/SCALE),
                                      new Point(616/SCALE, 398/SCALE),
                                      new Point(617/SCALE, 359/SCALE),
                                      new Point(612/SCALE, 353/SCALE),
                                      new Point(638/SCALE, 331/SCALE),
                                      new Point(652/SCALE, 326/SCALE),
                                      new Point(665/SCALE, 314/SCALE),
                                      new Point(660/SCALE, 303/SCALE),
                                      new Point(691/SCALE, 301/SCALE),
                                      new Point(700/SCALE, 312/SCALE),
                                      new Point(701/SCALE, 326/SCALE),
                                      new Point(674/SCALE, 374/SCALE),
                                      new Point(697/SCALE, 394/SCALE),
                                      new Point(701/SCALE, 401/SCALE),
                                      new Point(711/SCALE, 412/SCALE),
                                      new Point(720/SCALE, 422/SCALE),
                                      new Point(746/SCALE, 429/SCALE),
                                      new Point(752/SCALE, 433/SCALE),
                                      new Point(759/SCALE, 431/SCALE),
                                      new Point(772/SCALE, 473/SCALE),
                                      new Point(776/SCALE, 475/SCALE),
                                      new Point(789/SCALE, 472/SCALE),
                                      new Point(795/SCALE, 489/SCALE),
                                      new Point(789/SCALE, 492/SCALE),
                                      new Point(788/SCALE, 501/SCALE),
                                      new Point(776/SCALE, 503/SCALE),
                                      new Point(760/SCALE, 510/SCALE),
                                      new Point(759/SCALE, 519/SCALE),
                                      new Point(753/SCALE, 518/SCALE),
                                      new Point(744/SCALE, 527/SCALE),
                                      new Point(744/SCALE, 542/SCALE),
                                      new Point(741/SCALE, 553/SCALE),
                                      new Point(739/SCALE, 559/SCALE),
                                      new Point(742/SCALE, 565/SCALE),
                                      new Point(739/SCALE, 574/SCALE),
                                      new Point(734/SCALE, 572/SCALE),
                                      new Point(736/SCALE, 578/SCALE),
                                      new Point(724/SCALE, 579/SCALE),
                                      new Point(710/SCALE, 580/SCALE),
                                      new Point(702/SCALE, 580/SCALE),
                                      new Point(696/SCALE, 573/SCALE),
                                      new Point(694/SCALE, 579/SCALE),
                                      new Point(678/SCALE, 579/SCALE),
                                      new Point(674/SCALE, 577/SCALE),
                                      new Point(669/SCALE, 581/SCALE),
                                      new Point(656/SCALE, 580/SCALE),
                                      new Point(651/SCALE, 580/SCALE),
                                      new Point(640/SCALE, 580/SCALE),
                                      new Point(636/SCALE, 579/SCALE),
                                      new Point(635/SCALE, 573/SCALE),
                                      new Point(621/SCALE, 563/SCALE),
                                      new Point(622/SCALE, 559/SCALE),
                                      new Point(621/SCALE, 550/SCALE),
                                      new Point(624/SCALE, 547/SCALE),
                                      new Point(620/SCALE, 542/SCALE),
                                      new Point(622/SCALE, 537/SCALE)
                                  };
            irContinents[4] = new List<Point>
                                  {
                                      new Point(498/SCALE, 311/SCALE),
                                      new Point(598/SCALE, 338/SCALE),
                                      new Point(617/SCALE, 358/SCALE),
                                      new Point(615/SCALE, 399/SCALE),
                                      new Point(620/SCALE, 402/SCALE),
                                      new Point(624/SCALE, 416/SCALE),
                                      new Point(620/SCALE, 427/SCALE),
                                      new Point(626/SCALE, 439/SCALE),
                                      new Point(609/SCALE, 453/SCALE),
                                      new Point(616/SCALE, 460/SCALE),
                                      new Point(611/SCALE, 468/SCALE),
                                      new Point(612/SCALE, 490/SCALE),
                                      new Point(607/SCALE, 491/SCALE),
                                      new Point(605/SCALE, 498/SCALE),
                                      new Point(607/SCALE, 507/SCALE),
                                      new Point(611/SCALE, 512/SCALE),
                                      new Point(621/SCALE, 528/SCALE),
                                      new Point(620/SCALE, 533/SCALE),
                                      new Point(621/SCALE, 538/SCALE),
                                      new Point(603/SCALE, 531/SCALE),
                                      new Point(592/SCALE, 530/SCALE),
                                      new Point(578/SCALE, 523/SCALE),
                                      new Point(574/SCALE, 529/SCALE),
                                      new Point(567/SCALE, 526/SCALE),
                                      new Point(552/SCALE, 500/SCALE),
                                      new Point(547/SCALE, 497/SCALE),
                                      new Point(547/SCALE, 497/SCALE),
                                      new Point(550/SCALE, 493/SCALE),
                                      new Point(544/SCALE, 488/SCALE),
                                      new Point(540/SCALE, 484/SCALE),
                                      new Point(536/SCALE, 484/SCALE),
                                      new Point(532/SCALE, 472/SCALE),
                                      new Point(526/SCALE, 470/SCALE),
                                      new Point(514/SCALE, 481/SCALE),
                                      new Point(508/SCALE, 481/SCALE),
                                      new Point(494/SCALE, 470/SCALE),
                                      new Point(496/SCALE, 465/SCALE),
                                      new Point(491/SCALE, 447/SCALE),
                                      new Point(482/SCALE, 453/SCALE),
                                      new Point(476/SCALE, 458/SCALE),
                                      new Point(460/SCALE, 446/SCALE),
                                      new Point(454/SCALE, 437/SCALE),
                                      new Point(433/SCALE, 420/SCALE),
                                      new Point(433/SCALE, 395/SCALE),
                                      new Point(427/SCALE, 393/SCALE),
                                      new Point(424/SCALE, 384/SCALE),
                                      new Point(419/SCALE, 379/SCALE),
                                      new Point(426/SCALE, 364/SCALE),
                                      new Point(439/SCALE, 363/SCALE),
                                      new Point(462/SCALE, 353/SCALE),
                                      new Point(476/SCALE, 338/SCALE),
                                      new Point(488/SCALE, 330/SCALE),
                                      new Point(497/SCALE, 319/SCALE)
                                  };
            irContinents[5] = new List<Point>
                                  {
                                      new Point(440/SCALE, 259/SCALE),
                                      new Point(447/SCALE, 263/SCALE),
                                      new Point(457/SCALE, 277/SCALE),
                                      new Point(466/SCALE, 277/SCALE),
                                      new Point(472/SCALE, 280/SCALE),
                                      new Point(481/SCALE, 288/SCALE),
                                      new Point(493/SCALE, 307/SCALE),
                                      new Point(498/SCALE, 311/SCALE),
                                      new Point(496/SCALE, 320/SCALE),
                                      new Point(489/SCALE, 329/SCALE),
                                      new Point(476/SCALE, 338/SCALE),
                                      new Point(463/SCALE, 352/SCALE),
                                      new Point(449/SCALE, 360/SCALE),
                                      new Point(437/SCALE, 363/SCALE),
                                      new Point(426/SCALE, 364/SCALE),
                                      new Point(420/SCALE, 379/SCALE),
                                      new Point(426/SCALE, 387/SCALE),
                                      new Point(427/SCALE, 392/SCALE),
                                      new Point(432/SCALE, 396/SCALE),
                                      new Point(433/SCALE, 418/SCALE),
                                      new Point(428/SCALE, 425/SCALE),
                                      new Point(420/SCALE, 428/SCALE),
                                      new Point(412/SCALE, 423/SCALE),
                                      new Point(411/SCALE, 414/SCALE),
                                      new Point(401/SCALE, 407/SCALE),
                                      new Point(403/SCALE, 398/SCALE),
                                      new Point(405/SCALE, 393/SCALE),
                                      new Point(399/SCALE, 391/SCALE),
                                      new Point(392/SCALE, 383/SCALE),
                                      new Point(384/SCALE, 383/SCALE),
                                      new Point(373/SCALE, 378/SCALE),
                                      new Point(364/SCALE, 375/SCALE),
                                      new Point(359/SCALE, 368/SCALE),
                                      new Point(359/SCALE, 357/SCALE),
                                      new Point(351/SCALE, 349/SCALE),
                                      new Point(357/SCALE, 344/SCALE),
                                      new Point(354/SCALE, 339/SCALE),
                                      new Point(355/SCALE, 330/SCALE),
                                      new Point(354/SCALE, 306/SCALE),
                                      new Point(368/SCALE, 297/SCALE),
                                      new Point(385/SCALE, 299/SCALE),
                                      new Point(416/SCALE, 273/SCALE),
                                      new Point(433/SCALE, 268/SCALE)
                                  };
            irContinents[6] = new List<Point>
                                  {
                                      new Point(278/SCALE, 428/SCALE),
                                      new Point(278/SCALE, 424/SCALE),
                                      new Point(286/SCALE, 416/SCALE),
                                      new Point(288/SCALE, 411/SCALE),
                                      new Point(293/SCALE, 409/SCALE),
                                      new Point(294/SCALE, 400/SCALE),
                                      new Point(299/SCALE, 395/SCALE),
                                      new Point(308/SCALE, 403/SCALE),
                                      new Point(317/SCALE, 400/SCALE),
                                      new Point(320/SCALE, 394/SCALE),
                                      new Point(314/SCALE, 387/SCALE),
                                      new Point(316/SCALE, 381/SCALE),
                                      new Point(312/SCALE, 377/SCALE),
                                      new Point(318/SCALE, 370/SCALE),
                                      new Point(319/SCALE, 360/SCALE),
                                      new Point(315/SCALE, 357/SCALE),
                                      new Point(315/SCALE, 352/SCALE),
                                      new Point(324/SCALE, 347/SCALE),
                                      new Point(340/SCALE, 352/SCALE),
                                      new Point(349/SCALE, 349/SCALE),
                                      new Point(357/SCALE, 354/SCALE),
                                      new Point(360/SCALE, 366/SCALE),
                                      new Point(364/SCALE, 375/SCALE),
                                      new Point(371/SCALE, 379/SCALE),
                                      new Point(380/SCALE, 383/SCALE),
                                      new Point(392/SCALE, 382/SCALE),
                                      new Point(403/SCALE, 393/SCALE),
                                      new Point(401/SCALE, 406/SCALE),
                                      new Point(411/SCALE, 414/SCALE),
                                      new Point(412/SCALE, 424/SCALE),
                                      new Point(421/SCALE, 428/SCALE),
                                      new Point(427/SCALE, 425/SCALE),
                                      new Point(431/SCALE, 421/SCALE),
                                      new Point(454/SCALE, 436/SCALE),
                                      new Point(459/SCALE, 447/SCALE),
                                      new Point(460/SCALE, 459/SCALE),
                                      new Point(472/SCALE, 472/SCALE),
                                      new Point(471/SCALE, 489/SCALE),
                                      new Point(478/SCALE, 494/SCALE),
                                      new Point(471/SCALE, 503/SCALE),
                                      new Point(464/SCALE, 515/SCALE),
                                      new Point(455/SCALE, 518/SCALE),
                                      new Point(447/SCALE, 514/SCALE),
                                      new Point(439/SCALE, 517/SCALE),
                                      new Point(425/SCALE, 516/SCALE),
                                      new Point(419/SCALE, 523/SCALE),
                                      new Point(418/SCALE, 531/SCALE),
                                      new Point(405/SCALE, 537/SCALE),
                                      new Point(397/SCALE, 537/SCALE),
                                      new Point(388/SCALE, 532/SCALE),
                                      new Point(380/SCALE, 530/SCALE),
                                      new Point(358/SCALE, 517/SCALE),
                                      new Point(351/SCALE, 502/SCALE),
                                      new Point(344/SCALE, 501/SCALE),
                                      new Point(340/SCALE, 498/SCALE),
                                      new Point(342/SCALE, 493/SCALE),
                                      new Point(333/SCALE, 480/SCALE),
                                      new Point(332/SCALE, 473/SCALE),
                                      new Point(315/SCALE, 445/SCALE),
                                      new Point(300/SCALE, 441/SCALE),
                                      new Point(299/SCALE, 435/SCALE),
                                      new Point(290/SCALE, 430/SCALE)
                                  };
            irContinents[7] = new List<Point>
                                  {
                                      new Point(379/SCALE, 531/SCALE),
                                      new Point(385/SCALE, 531/SCALE),
                                      new Point(397/SCALE, 537/SCALE),
                                      new Point(418/SCALE, 530/SCALE),
                                      new Point(418/SCALE, 521/SCALE),
                                      new Point(425/SCALE, 516/SCALE),
                                      new Point(434/SCALE, 515/SCALE),
                                      new Point(438/SCALE, 517/SCALE),
                                      new Point(445/SCALE, 513/SCALE),
                                      new Point(456/SCALE, 517/SCALE),
                                      new Point(464/SCALE, 515/SCALE),
                                      new Point(469/SCALE, 506/SCALE),
                                      new Point(477/SCALE, 495/SCALE),
                                      new Point(472/SCALE, 487/SCALE),
                                      new Point(472/SCALE, 472/SCALE),
                                      new Point(460/SCALE, 462/SCALE),
                                      new Point(460/SCALE, 445/SCALE),
                                      new Point(474/SCALE, 456/SCALE),
                                      new Point(491/SCALE, 447/SCALE),
                                      new Point(495/SCALE, 464/SCALE),
                                      new Point(493/SCALE, 469/SCALE),
                                      new Point(509/SCALE, 483/SCALE),
                                      new Point(521/SCALE, 477/SCALE),
                                      new Point(528/SCALE, 468/SCALE),
                                      new Point(532/SCALE, 471/SCALE),
                                      new Point(537/SCALE, 483/SCALE),
                                      new Point(543/SCALE, 488/SCALE),
                                      new Point(550/SCALE, 493/SCALE),
                                      new Point(547/SCALE, 497/SCALE),
                                      new Point(552/SCALE, 500/SCALE),
                                      new Point(567/SCALE, 526/SCALE),
                                      new Point(574/SCALE, 529/SCALE),
                                      new Point(578/SCALE, 524/SCALE),
                                      new Point(592/SCALE, 528/SCALE),
                                      new Point(605/SCALE, 531/SCALE),
                                      new Point(622/SCALE, 537/SCALE),
                                      new Point(620/SCALE, 542/SCALE),
                                      new Point(624/SCALE, 547/SCALE),
                                      new Point(621/SCALE, 550/SCALE),
                                      new Point(622/SCALE, 559/SCALE),
                                      new Point(621/SCALE, 563/SCALE),
                                      new Point(635/SCALE, 573/SCALE),
                                      new Point(636/SCALE, 579/SCALE),
                                      new Point(638/SCALE, 587/SCALE),
                                      new Point(625/SCALE, 580/SCALE),
                                      new Point(620/SCALE, 582/SCALE),
                                      new Point(613/SCALE, 580/SCALE),
                                      new Point(604/SCALE, 581/SCALE),
                                      new Point(596/SCALE, 585/SCALE),
                                      new Point(589/SCALE, 581/SCALE),
                                      new Point(585/SCALE, 582/SCALE),
                                      new Point(581/SCALE, 580/SCALE),
                                      new Point(562/SCALE, 579/SCALE),
                                      new Point(558/SCALE, 572/SCALE),
                                      new Point(549/SCALE, 555/SCALE),
                                      new Point(547/SCALE, 539/SCALE),
                                      new Point(541/SCALE, 528/SCALE),
                                      new Point(527/SCALE, 525/SCALE),
                                      new Point(509/SCALE, 525/SCALE),
                                      new Point(498/SCALE, 533/SCALE),
                                      new Point(493/SCALE, 533/SCALE),
                                      new Point(488/SCALE, 541/SCALE),
                                      new Point(485/SCALE, 547/SCALE),
                                      new Point(475/SCALE, 547/SCALE),
                                      new Point(470/SCALE, 553/SCALE),
                                      new Point(457/SCALE, 564/SCALE),
                                      new Point(452/SCALE, 562/SCALE),
                                      new Point(443/SCALE, 562/SCALE),
                                      new Point(436/SCALE, 556/SCALE),
                                      new Point(424/SCALE, 559/SCALE),
                                      new Point(415/SCALE, 560/SCALE),
                                      new Point(406/SCALE, 554/SCALE),
                                      new Point(402/SCALE, 549/SCALE),
                                      new Point(389/SCALE, 547/SCALE),
                                      new Point(371/SCALE, 537/SCALE)
                                  };
            irContinents[8] = new List<Point>
                                  {
                                      new Point(380/SCALE, 530/SCALE),
                                      new Point(358/SCALE, 517/SCALE),
                                      new Point(351/SCALE, 502/SCALE),
                                      new Point(344/SCALE, 501/SCALE),
                                      new Point(340/SCALE, 498/SCALE),
                                      new Point(342/SCALE, 493/SCALE),
                                      new Point(333/SCALE, 480/SCALE),
                                      new Point(332/SCALE, 473/SCALE),
                                      new Point(315/SCALE, 445/SCALE),
                                      new Point(300/SCALE, 441/SCALE),
                                      new Point(299/SCALE, 435/SCALE),
                                      new Point(290/SCALE, 430/SCALE),
                                      new Point(275/SCALE, 429/SCALE),
                                      new Point(268/SCALE, 421/SCALE),
                                      new Point(262/SCALE, 419/SCALE),
                                      new Point(257/SCALE, 423/SCALE),
                                      new Point(260/SCALE, 432/SCALE),
                                      new Point(275/SCALE, 448/SCALE),
                                      new Point(277/SCALE, 452/SCALE),
                                      new Point(281/SCALE, 452/SCALE),
                                      new Point(283/SCALE, 461/SCALE),
                                      new Point(283/SCALE, 468/SCALE),
                                      new Point(291/SCALE, 469/SCALE),
                                      new Point(292/SCALE, 478/SCALE),
                                      new Point(297/SCALE, 481/SCALE),
                                      new Point(302/SCALE, 495/SCALE),
                                      new Point(312/SCALE, 507/SCALE),
                                      new Point(316/SCALE, 515/SCALE),
                                      new Point(326/SCALE, 520/SCALE),
                                      new Point(341/SCALE, 521/SCALE),
                                      new Point(357/SCALE, 527/SCALE),
                                      new Point(360/SCALE, 526/SCALE),
                                      new Point(371/SCALE, 533/SCALE),
                                      new Point(369/SCALE, 537/SCALE),
                                      new Point(379/SCALE, 531/SCALE)
                                  };
            irContinents[9] = new List<Point>
                                  {
                                      new Point(440/SCALE, 219/SCALE),
                                      new Point(455/SCALE, 218/SCALE),
                                      new Point(469/SCALE, 188/SCALE),
                                      new Point(488/SCALE, 173/SCALE),
                                      new Point(489/SCALE, 162/SCALE),
                                      new Point(493/SCALE, 156/SCALE),
                                      new Point(479/SCALE, 146/SCALE),
                                      new Point(472/SCALE, 132/SCALE),
                                      new Point(474/SCALE, 125/SCALE),
                                      new Point(476/SCALE, 119/SCALE),
                                      new Point(471/SCALE, 114/SCALE),
                                      new Point(463/SCALE, 117/SCALE),
                                      new Point(447/SCALE, 108/SCALE),
                                      new Point(444/SCALE, 102/SCALE),
                                      new Point(446/SCALE, 96/SCALE),
                                      new Point(437/SCALE, 89/SCALE),
                                      new Point(430/SCALE, 99/SCALE),
                                      new Point(430/SCALE, 108/SCALE),
                                      new Point(430/SCALE, 114/SCALE),
                                      new Point(414/SCALE, 116/SCALE),
                                      new Point(407/SCALE, 120/SCALE),
                                      new Point(401/SCALE, 124/SCALE),
                                      new Point(394/SCALE, 130/SCALE),
                                      new Point(385/SCALE, 130/SCALE),
                                      new Point(375/SCALE, 132/SCALE),
                                      new Point(372/SCALE, 136/SCALE),
                                      new Point(374/SCALE, 141/SCALE),
                                      new Point(361/SCALE, 152/SCALE),
                                      new Point(353/SCALE, 153/SCALE),
                                      new Point(347/SCALE, 158/SCALE),
                                      new Point(343/SCALE, 159/SCALE),
                                      new Point(341/SCALE, 162/SCALE),
                                      new Point(345/SCALE, 171/SCALE),
                                      new Point(343/SCALE, 177/SCALE),
                                      new Point(330/SCALE, 178/SCALE),
                                      new Point(319/SCALE, 185/SCALE),
                                      new Point(310/SCALE, 180/SCALE),
                                      new Point(302/SCALE, 180/SCALE),
                                      new Point(302/SCALE, 187/SCALE),
                                      new Point(309/SCALE, 197/SCALE),
                                      new Point(306/SCALE, 202/SCALE),
                                      new Point(306/SCALE, 213/SCALE),
                                      new Point(315/SCALE, 227/SCALE),
                                      new Point(324/SCALE, 224/SCALE),
                                      new Point(343/SCALE, 229/SCALE),
                                      new Point(406/SCALE, 220/SCALE),
                                      new Point(418/SCALE, 220/SCALE)
                                  };
            irContinents[10] = new List<Point>
                                   {
                                       new Point(375/SCALE, 132/SCALE),
                                       new Point(372/SCALE, 136/SCALE),
                                       new Point(374/SCALE, 141/SCALE),
                                       new Point(361/SCALE, 152/SCALE),
                                       new Point(353/SCALE, 153/SCALE),
                                       new Point(347/SCALE, 158/SCALE),
                                       new Point(343/SCALE, 159/SCALE),
                                       new Point(341/SCALE, 162/SCALE),
                                       new Point(324/SCALE, 159/SCALE),
                                       new Point(313/SCALE, 169/SCALE),
                                       new Point(305/SCALE, 168/SCALE),
                                       new Point(296/SCALE, 159/SCALE),
                                       new Point(282/SCALE, 158/SCALE),
                                       new Point(278/SCALE, 154/SCALE),
                                       new Point(273/SCALE, 154/SCALE),
                                       new Point(268/SCALE, 151/SCALE),
                                       new Point(239/SCALE, 136/SCALE),
                                       new Point(245/SCALE, 128/SCALE),
                                       new Point(250/SCALE, 121/SCALE),
                                       new Point(268/SCALE, 128/SCALE),
                                       new Point(296/SCALE, 132/SCALE),
                                       new Point(328/SCALE, 123/SCALE),
                                       new Point(370/SCALE, 105/SCALE)
                                   };
            irContinents[11] = new List<Point>
                                   {
                                       new Point(370/SCALE, 105/SCALE),
                                       new Point(365/SCALE, 89/SCALE),
                                       new Point(374/SCALE, 90/SCALE),
                                       new Point(384/SCALE, 83/SCALE),
                                       new Point(394/SCALE, 80/SCALE),
                                       new Point(393/SCALE, 74/SCALE),
                                       new Point(401/SCALE, 60/SCALE),
                                       new Point(414/SCALE, 47/SCALE),
                                       new Point(422/SCALE, 47/SCALE),
                                       new Point(423/SCALE, 44/SCALE),
                                       new Point(443/SCALE, 44/SCALE),
                                       new Point(445/SCALE, 60/SCALE),
                                       new Point(446/SCALE, 68/SCALE),
                                       new Point(450/SCALE, 74/SCALE),
                                       new Point(448/SCALE, 80/SCALE),
                                       new Point(439/SCALE, 84/SCALE),
                                       new Point(437/SCALE, 89/SCALE),
                                       new Point(430/SCALE, 99/SCALE),
                                       new Point(430/SCALE, 108/SCALE),
                                       new Point(430/SCALE, 114/SCALE),
                                       new Point(414/SCALE, 116/SCALE),
                                       new Point(407/SCALE, 120/SCALE),
                                       new Point(401/SCALE, 124/SCALE),
                                       new Point(394/SCALE, 130/SCALE),
                                       new Point(385/SCALE, 130/SCALE),
                                       new Point(375/SCALE, 132/SCALE)
                                   };
            irContinents[12] = new List<Point>
                                   {
                                       new Point(418/SCALE, 220/SCALE),
                                       new Point(406/SCALE, 220/SCALE),
                                       new Point(343/SCALE, 229/SCALE),
                                       new Point(324/SCALE, 224/SCALE),
                                       new Point(315/SCALE, 227/SCALE),
                                       new Point(314/SCALE, 230/SCALE),
                                       new Point(303/SCALE, 233/SCALE),
                                       new Point(298/SCALE, 234/SCALE),
                                       new Point(293/SCALE, 230/SCALE),
                                       new Point(293/SCALE, 226/SCALE),
                                       new Point(277/SCALE, 228/SCALE),
                                       new Point(274/SCALE, 232/SCALE),
                                       new Point(270/SCALE, 261/SCALE),
                                       new Point(265/SCALE, 264/SCALE),
                                       new Point(256/SCALE, 268/SCALE),
                                       new Point(247/SCALE, 268/SCALE),
                                       new Point(243/SCALE, 272/SCALE),
                                       new Point(239/SCALE, 276/SCALE),
                                       new Point(235/SCALE, 282/SCALE),
                                       new Point(235/SCALE, 288/SCALE),
                                       new Point(232/SCALE, 290/SCALE),
                                       new Point(235/SCALE, 293/SCALE),
                                       new Point(227/SCALE, 296/SCALE),
                                       new Point(230/SCALE, 304/SCALE),
                                       new Point(246/SCALE, 311/SCALE),
                                       new Point(251/SCALE, 316/SCALE),
                                       new Point(258/SCALE, 312/SCALE),
                                       new Point(258/SCALE, 308/SCALE),
                                       new Point(264/SCALE, 307/SCALE),
                                       new Point(274/SCALE, 307/SCALE),
                                       new Point(279/SCALE, 316/SCALE),
                                       new Point(278/SCALE, 321/SCALE),
                                       new Point(293/SCALE, 331/SCALE),
                                       new Point(295/SCALE, 339/SCALE),
                                       new Point(293/SCALE, 353/SCALE),
                                       new Point(298/SCALE, 370/SCALE),
                                       new Point(296/SCALE, 375/SCALE),
                                       new Point(314/SCALE, 386/SCALE),
                                       new Point(313/SCALE, 378/SCALE),
                                       new Point(317/SCALE, 371/SCALE),
                                       new Point(319/SCALE, 360/SCALE),
                                       new Point(314/SCALE, 357/SCALE),
                                       new Point(314/SCALE, 352/SCALE),
                                       new Point(324/SCALE, 347/SCALE),
                                       new Point(334/SCALE, 351/SCALE),
                                       new Point(345/SCALE, 351/SCALE),
                                       new Point(356/SCALE, 345/SCALE),
                                       new Point(354/SCALE, 338/SCALE),
                                       new Point(356/SCALE, 307/SCALE),
                                       new Point(369/SCALE, 296/SCALE),
                                       new Point(384/SCALE, 299/SCALE),
                                       new Point(416/SCALE, 273/SCALE),
                                       new Point(433/SCALE, 268/SCALE),
                                       new Point(441/SCALE, 260/SCALE),
                                       new Point(440/SCALE, 220/SCALE)
                                   };
            irContinents[13] = new List<Point>
                                   {
                                       new Point(273/SCALE, 234/SCALE),
                                       new Point(276/SCALE, 230/SCALE),
                                       new Point(292/SCALE, 227/SCALE),
                                       new Point(294/SCALE, 223/SCALE),
                                       new Point(296/SCALE, 222/SCALE),
                                       new Point(299/SCALE, 216/SCALE),
                                       new Point(305/SCALE, 214/SCALE),
                                       new Point(305/SCALE, 208/SCALE),
                                       new Point(290/SCALE, 203/SCALE),
                                       new Point(283/SCALE, 198/SCALE),
                                       new Point(273/SCALE, 196/SCALE),
                                       new Point(263/SCALE, 198/SCALE),
                                       new Point(261/SCALE, 210/SCALE),
                                       new Point(252/SCALE, 211/SCALE),
                                       new Point(247/SCALE, 216/SCALE),
                                       new Point(241/SCALE, 215/SCALE),
                                       new Point(239/SCALE, 219/SCALE),
                                       new Point(241/SCALE, 221/SCALE),
                                       new Point(236/SCALE, 222/SCALE),
                                       new Point(238/SCALE, 228/SCALE),
                                       new Point(243/SCALE, 230/SCALE),
                                       new Point(246/SCALE, 228/SCALE),
                                       new Point(254/SCALE, 240/SCALE),
                                       new Point(260/SCALE, 237/SCALE),
                                       new Point(264/SCALE, 240/SCALE),
                                       new Point(273/SCALE, 242/SCALE)
                                   };
            irContinents[14] = new List<Point>
                                   {
                                       new Point(305/SCALE, 209/SCALE),
                                       new Point(305/SCALE, 204/SCALE),
                                       new Point(309/SCALE, 198/SCALE),
                                       new Point(301/SCALE, 189/SCALE),
                                       new Point(303/SCALE, 179/SCALE),
                                       new Point(309/SCALE, 180/SCALE),
                                       new Point(319/SCALE, 184/SCALE),
                                       new Point(330/SCALE, 179/SCALE),
                                       new Point(344/SCALE, 175/SCALE),
                                       new Point(340/SCALE, 162/SCALE),
                                       new Point(323/SCALE, 160/SCALE),
                                       new Point(317/SCALE, 163/SCALE),
                                       new Point(313/SCALE, 169/SCALE),
                                       new Point(305/SCALE, 168/SCALE),
                                       new Point(296/SCALE, 159/SCALE),
                                       new Point(284/SCALE, 159/SCALE),
                                       new Point(279/SCALE, 154/SCALE),
                                       new Point(273/SCALE, 154/SCALE),
                                       new Point(269/SCALE, 151/SCALE),
                                       new Point(259/SCALE, 148/SCALE),
                                       new Point(245/SCALE, 150/SCALE),
                                       new Point(246/SCALE, 154/SCALE),
                                       new Point(252/SCALE, 157/SCALE),
                                       new Point(249/SCALE, 161/SCALE),
                                       new Point(249/SCALE, 165/SCALE),
                                       new Point(243/SCALE, 170/SCALE),
                                       new Point(241/SCALE, 173/SCALE),
                                       new Point(241/SCALE, 178/SCALE),
                                       new Point(237/SCALE, 181/SCALE),
                                       new Point(249/SCALE, 181/SCALE),
                                       new Point(263/SCALE, 186/SCALE),
                                       new Point(262/SCALE, 197/SCALE),
                                       new Point(273/SCALE, 195/SCALE),
                                       new Point(292/SCALE, 203/SCALE)
                                   };
            irContinents[15] = new List<Point>
                                   {
                                       new Point(250/SCALE, 120/SCALE),
                                       new Point(238/SCALE, 113/SCALE),
                                       new Point(229/SCALE, 102/SCALE),
                                       new Point(215/SCALE, 101/SCALE),
                                       new Point(204/SCALE, 98/SCALE),
                                       new Point(197/SCALE, 97/SCALE),
                                       new Point(187/SCALE, 89/SCALE),
                                       new Point(183/SCALE, 71/SCALE),
                                       new Point(180/SCALE, 68/SCALE),
                                       new Point(180/SCALE, 58/SCALE),
                                       new Point(175/SCALE, 60/SCALE),
                                       new Point(172/SCALE, 61/SCALE),
                                       new Point(176/SCALE, 69/SCALE),
                                       new Point(172/SCALE, 85/SCALE),
                                       new Point(176/SCALE, 90/SCALE),
                                       new Point(175/SCALE, 94/SCALE),
                                       new Point(181/SCALE, 104/SCALE),
                                       new Point(188/SCALE, 109/SCALE),
                                       new Point(187/SCALE, 114/SCALE),
                                       new Point(199/SCALE, 126/SCALE),
                                       new Point(199/SCALE, 130/SCALE),
                                       new Point(203/SCALE, 132/SCALE),
                                       new Point(210/SCALE, 140/SCALE),
                                       new Point(221/SCALE, 142/SCALE),
                                       new Point(239/SCALE, 136/SCALE)
                                   };
            irContinents[16] = new List<Point>
                                   {
                                       new Point(259/SCALE, 148/SCALE),
                                       new Point(245/SCALE, 150/SCALE),
                                       new Point(246/SCALE, 154/SCALE),
                                       new Point(252/SCALE, 157/SCALE),
                                       new Point(249/SCALE, 161/SCALE),
                                       new Point(249/SCALE, 165/SCALE),
                                       new Point(243/SCALE, 170/SCALE),
                                       new Point(241/SCALE, 173/SCALE),
                                       new Point(241/SCALE, 178/SCALE),
                                       new Point(237/SCALE, 181/SCALE),
                                       new Point(234/SCALE, 179/SCALE),
                                       new Point(224/SCALE, 184/SCALE),
                                       new Point(218/SCALE, 184/SCALE),
                                       new Point(216/SCALE, 188/SCALE),
                                       new Point(205/SCALE, 188/SCALE),
                                       new Point(195/SCALE, 189/SCALE),
                                       new Point(196/SCALE, 185/SCALE),
                                       new Point(191/SCALE, 180/SCALE),
                                       new Point(186/SCALE, 179/SCALE),
                                       new Point(179/SCALE, 174/SCALE),
                                       new Point(188/SCALE, 170/SCALE),
                                       new Point(193/SCALE, 170/SCALE),
                                       new Point(206/SCALE, 162/SCALE),
                                       new Point(202/SCALE, 149/SCALE),
                                       new Point(194/SCALE, 146/SCALE),
                                       new Point(194/SCALE, 142/SCALE),
                                       new Point(190/SCALE, 140/SCALE),
                                       new Point(195/SCALE, 132/SCALE),
                                       new Point(202/SCALE, 132/SCALE),
                                       new Point(209/SCALE, 140/SCALE),
                                       new Point(221/SCALE, 142/SCALE),
                                       new Point(234/SCALE, 135/SCALE)
                                   };
            irContinents[17] = new List<Point>
                                   {
                                       new Point(230/SCALE, 304/SCALE),
                                       new Point(246/SCALE, 311/SCALE),
                                       new Point(251/SCALE, 316/SCALE),
                                       new Point(258/SCALE, 312/SCALE),
                                       new Point(258/SCALE, 308/SCALE),
                                       new Point(264/SCALE, 307/SCALE),
                                       new Point(274/SCALE, 307/SCALE),
                                       new Point(279/SCALE, 316/SCALE),
                                       new Point(278/SCALE, 321/SCALE),
                                       new Point(293/SCALE, 331/SCALE),
                                       new Point(295/SCALE, 339/SCALE),
                                       new Point(293/SCALE, 353/SCALE),
                                       new Point(298/SCALE, 370/SCALE),
                                       new Point(293/SCALE, 370/SCALE),
                                       new Point(289/SCALE, 374/SCALE),
                                       new Point(280/SCALE, 368/SCALE),
                                       new Point(275/SCALE, 367/SCALE),
                                       new Point(269/SCALE, 363/SCALE),
                                       new Point(259/SCALE, 359/SCALE),
                                       new Point(259/SCALE, 354/SCALE),
                                       new Point(256/SCALE, 350/SCALE),
                                       new Point(254/SCALE, 343/SCALE),
                                       new Point(247/SCALE, 338/SCALE),
                                       new Point(246/SCALE, 333/SCALE),
                                       new Point(242/SCALE, 333/SCALE),
                                       new Point(219/SCALE, 313/SCALE),
                                       new Point(218/SCALE, 309/SCALE),
                                       new Point(224/SCALE, 309/SCALE),
                                       new Point(225/SCALE, 306/SCALE)
                                   };
            irContinents[18] = new List<Point>
                                   {
                                       new Point(278/SCALE, 428/SCALE),
                                       new Point(278/SCALE, 424/SCALE),
                                       new Point(286/SCALE, 416/SCALE),
                                       new Point(288/SCALE, 411/SCALE),
                                       new Point(293/SCALE, 409/SCALE),
                                       new Point(294/SCALE, 400/SCALE),
                                       new Point(299/SCALE, 395/SCALE),
                                       new Point(308/SCALE, 403/SCALE),
                                       new Point(317/SCALE, 400/SCALE),
                                       new Point(320/SCALE, 394/SCALE),
                                       new Point(314/SCALE, 387/SCALE),
                                       new Point(296/SCALE, 375/SCALE),
                                       new Point(298/SCALE, 370/SCALE),
                                       new Point(293/SCALE, 370/SCALE),
                                       new Point(289/SCALE, 374/SCALE),
                                       new Point(280/SCALE, 368/SCALE),
                                       new Point(275/SCALE, 367/SCALE),
                                       new Point(269/SCALE, 363/SCALE),
                                       new Point(259/SCALE, 359/SCALE),
                                       new Point(254/SCALE, 360/SCALE),
                                       new Point(252/SCALE, 368/SCALE),
                                       new Point(243/SCALE, 371/SCALE),
                                       new Point(241/SCALE, 383/SCALE),
                                       new Point(247/SCALE, 388/SCALE),
                                       new Point(253/SCALE, 386/SCALE),
                                       new Point(267/SCALE, 399/SCALE),
                                       new Point(267/SCALE, 409/SCALE),
                                       new Point(277/SCALE, 424/SCALE)
                                   };
            irContinents[19] = new List<Point>
                                   {
                                       new Point(277/SCALE, 428/SCALE),
                                       new Point(268/SCALE, 421/SCALE),
                                       new Point(261/SCALE, 420/SCALE),
                                       new Point(257/SCALE, 423/SCALE),
                                       new Point(249/SCALE, 423/SCALE),
                                       new Point(238/SCALE, 431/SCALE),
                                       new Point(232/SCALE, 425/SCALE),
                                       new Point(224/SCALE, 426/SCALE),
                                       new Point(213/SCALE, 419/SCALE),
                                       new Point(223/SCALE, 417/SCALE),
                                       new Point(223/SCALE, 412/SCALE),
                                       new Point(212/SCALE, 411/SCALE),
                                       new Point(208/SCALE, 417/SCALE),
                                       new Point(210/SCALE, 430/SCALE),
                                       new Point(202/SCALE, 426/SCALE),
                                       new Point(203/SCALE, 432/SCALE),
                                       new Point(196/SCALE, 430/SCALE),
                                       new Point(200/SCALE, 437/SCALE),
                                       new Point(181/SCALE, 419/SCALE),
                                       new Point(175/SCALE, 419/SCALE),
                                       new Point(172/SCALE, 394/SCALE),
                                       new Point(161/SCALE, 393/SCALE),
                                       new Point(158/SCALE, 373/SCALE),
                                       new Point(164/SCALE, 358/SCALE),
                                       new Point(153/SCALE, 345/SCALE),
                                       new Point(157/SCALE, 338/SCALE),
                                       new Point(161/SCALE, 314/SCALE),
                                       new Point(165/SCALE, 309/SCALE),
                                       new Point(169/SCALE, 297/SCALE),
                                       new Point(188/SCALE, 295/SCALE),
                                       new Point(192/SCALE, 299/SCALE),
                                       new Point(204/SCALE, 299/SCALE),
                                       new Point(209/SCALE, 304/SCALE),
                                       new Point(218/SCALE, 309/SCALE),
                                       new Point(219/SCALE, 313/SCALE),
                                       new Point(242/SCALE, 333/SCALE),
                                       new Point(246/SCALE, 333/SCALE),
                                       new Point(247/SCALE, 338/SCALE),
                                       new Point(254/SCALE, 343/SCALE),
                                       new Point(256/SCALE, 350/SCALE),
                                       new Point(259/SCALE, 354/SCALE),
                                       new Point(259/SCALE, 359/SCALE),
                                       new Point(254/SCALE, 360/SCALE),
                                       new Point(252/SCALE, 368/SCALE),
                                       new Point(243/SCALE, 371/SCALE),
                                       new Point(241/SCALE, 383/SCALE),
                                       new Point(247/SCALE, 388/SCALE),
                                       new Point(253/SCALE, 386/SCALE),
                                       new Point(267/SCALE, 399/SCALE),
                                       new Point(267/SCALE, 409/SCALE),
                                       new Point(277/SCALE, 424/SCALE)
                                   };
            irContinents[20] = new List<Point>
                                   {
                                       new Point(153/SCALE, 345/SCALE),
                                       new Point(157/SCALE, 338/SCALE),
                                       new Point(161/SCALE, 314/SCALE),
                                       new Point(154/SCALE, 300/SCALE),
                                       new Point(137/SCALE, 289/SCALE),
                                       new Point(132/SCALE, 288/SCALE),
                                       new Point(129/SCALE, 284/SCALE),
                                       new Point(124/SCALE, 284/SCALE),
                                       new Point(119/SCALE, 279/SCALE),
                                       new Point(118/SCALE, 275/SCALE),
                                       new Point(122/SCALE, 274/SCALE),
                                       new Point(123/SCALE, 270/SCALE),
                                       new Point(131/SCALE, 268/SCALE),
                                       new Point(137/SCALE, 267/SCALE),
                                       new Point(142/SCALE, 264/SCALE),
                                       new Point(140/SCALE, 259/SCALE),
                                       new Point(135/SCALE, 259/SCALE),
                                       new Point(131/SCALE, 264/SCALE),
                                       new Point(120/SCALE, 266/SCALE),
                                       new Point(105/SCALE, 263/SCALE),
                                       new Point(99/SCALE, 260/SCALE),
                                       new Point(89/SCALE, 258/SCALE),
                                       new Point(86/SCALE, 255/SCALE),
                                       new Point(78/SCALE, 259/SCALE),
                                       new Point(75/SCALE, 272/SCALE),
                                       new Point(82/SCALE, 283/SCALE),
                                       new Point(82/SCALE, 287/SCALE),
                                       new Point(97/SCALE, 299/SCALE),
                                       new Point(94/SCALE, 307/SCALE),
                                       new Point(98/SCALE, 311/SCALE),
                                       new Point(108/SCALE, 312/SCALE),
                                       new Point(135/SCALE, 332/SCALE),
                                       new Point(144/SCALE, 332/SCALE)
                                   };
            irContinents[21] = new List<Point>
                                   {
                                       new Point(67/SCALE, 266/SCALE),
                                       new Point(69/SCALE, 260/SCALE),
                                       new Point(67/SCALE, 257/SCALE),
                                       new Point(72/SCALE, 256/SCALE),
                                       new Point(73/SCALE, 252/SCALE),
                                       new Point(69/SCALE, 250/SCALE),
                                       new Point(68/SCALE, 244/SCALE),
                                       new Point(79/SCALE, 239/SCALE),
                                       new Point(75/SCALE, 230/SCALE),
                                       new Point(83/SCALE, 222/SCALE),
                                       new Point(83/SCALE, 216/SCALE),
                                       new Point(91/SCALE, 217/SCALE),
                                       new Point(94/SCALE, 208/SCALE),
                                       new Point(109/SCALE, 223/SCALE),
                                       new Point(119/SCALE, 224/SCALE),
                                       new Point(124/SCALE, 218/SCALE),
                                       new Point(133/SCALE, 209/SCALE),
                                       new Point(138/SCALE, 209/SCALE),
                                       new Point(137/SCALE, 204/SCALE),
                                       new Point(159/SCALE, 215/SCALE),
                                       new Point(152/SCALE, 218/SCALE),
                                       new Point(154/SCALE, 223/SCALE),
                                       new Point(152/SCALE, 228/SCALE),
                                       new Point(155/SCALE, 231/SCALE),
                                       new Point(159/SCALE, 227/SCALE),
                                       new Point(163/SCALE, 231/SCALE),
                                       new Point(157/SCALE, 242/SCALE),
                                       new Point(145/SCALE, 239/SCALE),
                                       new Point(145/SCALE, 246/SCALE),
                                       new Point(139/SCALE, 248/SCALE),
                                       new Point(139/SCALE, 254/SCALE),
                                       new Point(143/SCALE, 257/SCALE),
                                       new Point(140/SCALE, 259/SCALE),
                                       new Point(135/SCALE, 259/SCALE),
                                       new Point(131/SCALE, 264/SCALE),
                                       new Point(120/SCALE, 266/SCALE),
                                       new Point(105/SCALE, 263/SCALE),
                                       new Point(99/SCALE, 260/SCALE),
                                       new Point(89/SCALE, 258/SCALE),
                                       new Point(86/SCALE, 255/SCALE),
                                       new Point(78/SCALE, 259/SCALE),
                                       new Point(75/SCALE, 272/SCALE)
                                   };
            irContinents[22] = new List<Point>
                                   {
                                       new Point(166/SCALE, 247/SCALE),
                                       new Point(169/SCALE, 252/SCALE),
                                       new Point(177/SCALE, 254/SCALE),
                                       new Point(187/SCALE, 248/SCALE),
                                       new Point(197/SCALE, 252/SCALE),
                                       new Point(197/SCALE, 262/SCALE),
                                       new Point(209/SCALE, 266/SCALE),
                                       new Point(210/SCALE, 259/SCALE),
                                       new Point(217/SCALE, 256/SCALE),
                                       new Point(222/SCALE, 259/SCALE),
                                       new Point(222/SCALE, 266/SCALE),
                                       new Point(229/SCALE, 269/SCALE),
                                       new Point(231/SCALE, 265/SCALE),
                                       new Point(237/SCALE, 274/SCALE),
                                       new Point(239/SCALE, 276/SCALE),
                                       new Point(235/SCALE, 282/SCALE),
                                       new Point(235/SCALE, 288/SCALE),
                                       new Point(232/SCALE, 290/SCALE),
                                       new Point(235/SCALE, 293/SCALE),
                                       new Point(227/SCALE, 296/SCALE),
                                       new Point(230/SCALE, 304/SCALE),
                                       new Point(225/SCALE, 306/SCALE),
                                       new Point(224/SCALE, 309/SCALE),
                                       new Point(218/SCALE, 309/SCALE),
                                       new Point(209/SCALE, 304/SCALE),
                                       new Point(204/SCALE, 299/SCALE),
                                       new Point(192/SCALE, 299/SCALE),
                                       new Point(188/SCALE, 295/SCALE),
                                       new Point(169/SCALE, 297/SCALE),
                                       new Point(165/SCALE, 309/SCALE),
                                       new Point(161/SCALE, 314/SCALE),
                                       new Point(154/SCALE, 300/SCALE),
                                       new Point(137/SCALE, 289/SCALE),
                                       new Point(132/SCALE, 288/SCALE),
                                       new Point(129/SCALE, 284/SCALE),
                                       new Point(124/SCALE, 284/SCALE),
                                       new Point(119/SCALE, 279/SCALE),
                                       new Point(118/SCALE, 275/SCALE),
                                       new Point(122/SCALE, 274/SCALE),
                                       new Point(123/SCALE, 270/SCALE),
                                       new Point(131/SCALE, 268/SCALE),
                                       new Point(137/SCALE, 267/SCALE),
                                       new Point(142/SCALE, 264/SCALE),
                                       new Point(140/SCALE, 259/SCALE),
                                       new Point(143/SCALE, 257/SCALE),
                                       new Point(139/SCALE, 254/SCALE),
                                       new Point(139/SCALE, 248/SCALE),
                                       new Point(145/SCALE, 246/SCALE),
                                       new Point(145/SCALE, 239/SCALE),
                                       new Point(157/SCALE, 242/SCALE)
                                   };
            irContinents[23] = new List<Point>
                                   {
                                       new Point(195/SCALE, 189/SCALE),
                                       new Point(205/SCALE, 188/SCALE),
                                       new Point(216/SCALE, 188/SCALE),
                                       new Point(218/SCALE, 184/SCALE),
                                       new Point(224/SCALE, 184/SCALE),
                                       new Point(234/SCALE, 179/SCALE),
                                       new Point(237/SCALE, 181/SCALE),
                                       new Point(241/SCALE, 178/SCALE),
                                       new Point(237/SCALE, 181/SCALE),
                                       new Point(249/SCALE, 181/SCALE),
                                       new Point(263/SCALE, 186/SCALE),
                                       new Point(263/SCALE, 198/SCALE),
                                       new Point(261/SCALE, 210/SCALE),
                                       new Point(252/SCALE, 211/SCALE),
                                       new Point(247/SCALE, 216/SCALE),
                                       new Point(241/SCALE, 215/SCALE),
                                       new Point(239/SCALE, 219/SCALE),
                                       new Point(241/SCALE, 221/SCALE),
                                       new Point(236/SCALE, 222/SCALE),
                                       new Point(238/SCALE, 228/SCALE),
                                       new Point(243/SCALE, 230/SCALE),
                                       new Point(246/SCALE, 228/SCALE),
                                       new Point(254/SCALE, 240/SCALE),
                                       new Point(260/SCALE, 237/SCALE),
                                       new Point(264/SCALE, 240/SCALE),
                                       new Point(273/SCALE, 242/SCALE),
                                       new Point(270/SCALE, 261/SCALE),
                                       new Point(265/SCALE, 264/SCALE),
                                       new Point(256/SCALE, 268/SCALE),
                                       new Point(247/SCALE, 268/SCALE),
                                       new Point(243/SCALE, 272/SCALE),
                                       new Point(239/SCALE, 276/SCALE),
                                       new Point(237/SCALE, 274/SCALE),
                                       new Point(231/SCALE, 265/SCALE),
                                       new Point(229/SCALE, 269/SCALE),
                                       new Point(222/SCALE, 266/SCALE),
                                       new Point(222/SCALE, 259/SCALE),
                                       new Point(217/SCALE, 256/SCALE),
                                       new Point(210/SCALE, 259/SCALE),
                                       new Point(209/SCALE, 266/SCALE),
                                       new Point(197/SCALE, 262/SCALE),
                                       new Point(197/SCALE, 252/SCALE),
                                       new Point(202/SCALE, 251/SCALE),
                                       new Point(202/SCALE, 243/SCALE),
                                       new Point(199/SCALE, 239/SCALE),
                                       new Point(197/SCALE, 236/SCALE),
                                       new Point(198/SCALE, 230/SCALE),
                                       new Point(200/SCALE, 225/SCALE),
                                       new Point(200/SCALE, 218/SCALE),
                                       new Point(212/SCALE, 214/SCALE),
                                       new Point(207/SCALE, 212/SCALE),
                                       new Point(207/SCALE, 208/SCALE),
                                       new Point(210/SCALE, 209/SCALE),
                                       new Point(211/SCALE, 203/SCALE),
                                       new Point(206/SCALE, 196/SCALE),
                                       new Point(206/SCALE, 191/SCALE)
                                   };
            irContinents[24] = new List<Point>
                                   {
                                       new Point(157/SCALE, 242/SCALE),
                                       new Point(166/SCALE, 247/SCALE),
                                       new Point(169/SCALE, 252/SCALE),
                                       new Point(177/SCALE, 254/SCALE),
                                       new Point(187/SCALE, 248/SCALE),
                                       new Point(197/SCALE, 252/SCALE),
                                       new Point(202/SCALE, 251/SCALE),
                                       new Point(202/SCALE, 243/SCALE),
                                       new Point(199/SCALE, 239/SCALE),
                                       new Point(197/SCALE, 236/SCALE),
                                       new Point(198/SCALE, 230/SCALE),
                                       new Point(200/SCALE, 225/SCALE),
                                       new Point(200/SCALE, 218/SCALE),
                                       new Point(212/SCALE, 214/SCALE),
                                       new Point(207/SCALE, 212/SCALE),
                                       new Point(207/SCALE, 208/SCALE),
                                       new Point(210/SCALE, 209/SCALE),
                                       new Point(211/SCALE, 203/SCALE),
                                       new Point(206/SCALE, 196/SCALE),
                                       new Point(206/SCALE, 191/SCALE),
                                       new Point(195/SCALE, 189/SCALE),
                                       new Point(196/SCALE, 185/SCALE),
                                       new Point(191/SCALE, 180/SCALE),
                                       new Point(186/SCALE, 179/SCALE),
                                       new Point(186/SCALE, 180/SCALE),
                                       new Point(187/SCALE, 185/SCALE),
                                       new Point(181/SCALE, 188/SCALE),
                                       new Point(174/SCALE, 183/SCALE),
                                       new Point(170/SCALE, 186/SCALE),
                                       new Point(164/SCALE, 180/SCALE),
                                       new Point(157/SCALE, 179/SCALE),
                                       new Point(160/SCALE, 182/SCALE),
                                       new Point(156/SCALE, 186/SCALE),
                                       new Point(152/SCALE, 184/SCALE),
                                       new Point(149/SCALE, 186/SCALE),
                                       new Point(156/SCALE, 198/SCALE),
                                       new Point(163/SCALE, 201/SCALE),
                                       new Point(164/SCALE, 206/SCALE),
                                       new Point(159/SCALE, 215/SCALE),
                                       new Point(152/SCALE, 218/SCALE),
                                       new Point(154/SCALE, 223/SCALE),
                                       new Point(152/SCALE, 228/SCALE),
                                       new Point(155/SCALE, 231/SCALE),
                                       new Point(159/SCALE, 227/SCALE),
                                       new Point(163/SCALE, 231/SCALE),
                                       new Point(157/SCALE, 242/SCALE)
                                   };
            irContinents[25] = new List<Point>
                                   {
                                       new Point(94/SCALE, 208/SCALE),
                                       new Point(109/SCALE, 223/SCALE),
                                       new Point(119/SCALE, 224/SCALE),
                                       new Point(124/SCALE, 218/SCALE),
                                       new Point(133/SCALE, 209/SCALE),
                                       new Point(138/SCALE, 209/SCALE),
                                       new Point(137/SCALE, 204/SCALE),
                                       new Point(159/SCALE, 215/SCALE),
                                       new Point(164/SCALE, 206/SCALE),
                                       new Point(163/SCALE, 201/SCALE),
                                       new Point(156/SCALE, 198/SCALE),
                                       new Point(149/SCALE, 186/SCALE),
                                       new Point(152/SCALE, 184/SCALE),
                                       new Point(156/SCALE, 186/SCALE),
                                       new Point(160/SCALE, 182/SCALE),
                                       new Point(157/SCALE, 179/SCALE),
                                       new Point(164/SCALE, 180/SCALE),
                                       new Point(152/SCALE, 172/SCALE),
                                       new Point(154/SCALE, 160/SCALE),
                                       new Point(152/SCALE, 153/SCALE),
                                       new Point(133/SCALE, 151/SCALE),
                                       new Point(130/SCALE, 147/SCALE),
                                       new Point(125/SCALE, 157/SCALE),
                                       new Point(117/SCALE, 156/SCALE),
                                       new Point(113/SCALE, 152/SCALE),
                                       new Point(91/SCALE, 153/SCALE),
                                       new Point(86/SCALE, 150/SCALE),
                                       new Point(81/SCALE, 152/SCALE),
                                       new Point(79/SCALE, 159/SCALE),
                                       new Point(70/SCALE, 161/SCALE),
                                       new Point(65/SCALE, 172/SCALE),
                                       new Point(60/SCALE, 173/SCALE),
                                       new Point(61/SCALE, 177/SCALE),
                                       new Point(70/SCALE, 177/SCALE),
                                       new Point(77/SCALE, 184/SCALE),
                                       new Point(81/SCALE, 182/SCALE),
                                       new Point(97/SCALE, 182/SCALE),
                                       new Point(86/SCALE, 190/SCALE),
                                       new Point(87/SCALE, 199/SCALE)
                                   };
            irContinents[26] = new List<Point>
                                   {
                                       new Point(164/SCALE, 180/SCALE),
                                       new Point(152/SCALE, 172/SCALE),
                                       new Point(154/SCALE, 160/SCALE),
                                       new Point(152/SCALE, 153/SCALE),
                                       new Point(133/SCALE, 151/SCALE),
                                       new Point(130/SCALE, 147/SCALE),
                                       new Point(131/SCALE, 128/SCALE),
                                       new Point(136/SCALE, 121/SCALE),
                                       new Point(152/SCALE, 121/SCALE),
                                       new Point(162/SCALE, 117/SCALE),
                                       new Point(167/SCALE, 118/SCALE),
                                       new Point(173/SCALE, 114/SCALE),
                                       new Point(177/SCALE, 119/SCALE),
                                       new Point(180/SCALE, 114/SCALE),
                                       new Point(187/SCALE, 114/SCALE),
                                       new Point(199/SCALE, 126/SCALE),
                                       new Point(199/SCALE, 130/SCALE),
                                       new Point(195/SCALE, 132/SCALE),
                                       new Point(190/SCALE, 140/SCALE),
                                       new Point(194/SCALE, 142/SCALE),
                                       new Point(194/SCALE, 146/SCALE),
                                       new Point(202/SCALE, 149/SCALE),
                                       new Point(206/SCALE, 162/SCALE),
                                       new Point(193/SCALE, 170/SCALE),
                                       new Point(188/SCALE, 170/SCALE),
                                       new Point(179/SCALE, 174/SCALE),
                                       new Point(186/SCALE, 180/SCALE),
                                       new Point(187/SCALE, 185/SCALE),
                                       new Point(181/SCALE, 188/SCALE),
                                       new Point(174/SCALE, 183/SCALE),
                                       new Point(170/SCALE, 186/SCALE),
                                       new Point(164/SCALE, 180/SCALE)
                                   };
            irContinents[27] = new List<Point>
                                   {
                                       new Point(131/SCALE, 128/SCALE),
                                       new Point(130/SCALE, 147/SCALE),
                                       new Point(125/SCALE, 157/SCALE),
                                       new Point(117/SCALE, 156/SCALE),
                                       new Point(113/SCALE, 152/SCALE),
                                       new Point(91/SCALE, 153/SCALE),
                                       new Point(86/SCALE, 150/SCALE),
                                       new Point(81/SCALE, 152/SCALE),
                                       new Point(79/SCALE, 159/SCALE),
                                       new Point(70/SCALE, 161/SCALE),
                                       new Point(65/SCALE, 172/SCALE),
                                       new Point(60/SCALE, 173/SCALE),
                                       new Point(56/SCALE, 166/SCALE),
                                       new Point(57/SCALE, 162/SCALE),
                                       new Point(56/SCALE, 158/SCALE),
                                       new Point(53/SCALE, 160/SCALE),
                                       new Point(48/SCALE, 152/SCALE),
                                       new Point(48/SCALE, 145/SCALE),
                                       new Point(41/SCALE, 141/SCALE),
                                       new Point(42/SCALE, 132/SCALE),
                                       new Point(37/SCALE, 124/SCALE),
                                       new Point(38/SCALE, 118/SCALE),
                                       new Point(31/SCALE, 112/SCALE),
                                       new Point(30/SCALE, 98/SCALE),
                                       new Point(24/SCALE, 99/SCALE),
                                       new Point(22/SCALE, 95/SCALE),
                                       new Point(18/SCALE, 95/SCALE),
                                       new Point(17/SCALE, 85/SCALE),
                                       new Point(21/SCALE, 82/SCALE),
                                       new Point(23/SCALE, 73/SCALE),
                                       new Point(19/SCALE, 71/SCALE),
                                       new Point(20/SCALE, 62/SCALE),
                                       new Point(15/SCALE, 56/SCALE),
                                       new Point(18/SCALE, 52/SCALE),
                                       new Point(12/SCALE, 45/SCALE),
                                       new Point(15/SCALE, 39/SCALE),
                                       new Point(11/SCALE, 34/SCALE),
                                       new Point(8/SCALE, 24/SCALE),
                                       new Point(21/SCALE, 23/SCALE),
                                       new Point(24/SCALE, 10/SCALE),
                                       new Point(29/SCALE, 10/SCALE),
                                       new Point(49/SCALE, 32/SCALE),
                                       new Point(55/SCALE, 34/SCALE),
                                       new Point(59/SCALE, 41/SCALE),
                                       new Point(47/SCALE, 68/SCALE),
                                       new Point(47/SCALE, 73/SCALE),
                                       new Point(43/SCALE, 76/SCALE),
                                       new Point(44/SCALE, 79/SCALE),
                                       new Point(50/SCALE, 80/SCALE),
                                       new Point(47/SCALE, 86/SCALE),
                                       new Point(46/SCALE, 92/SCALE),
                                       new Point(53/SCALE, 99/SCALE),
                                       new Point(55/SCALE, 118/SCALE),
                                       new Point(60/SCALE, 124/SCALE),
                                       new Point(66/SCALE, 122/SCALE),
                                       new Point(68/SCALE, 118/SCALE),
                                       new Point(74/SCALE, 121/SCALE),
                                       new Point(80/SCALE, 121/SCALE),
                                       new Point(85/SCALE, 127/SCALE),
                                       new Point(101/SCALE, 127/SCALE),
                                       new Point(107/SCALE, 125/SCALE),
                                       new Point(112/SCALE, 127/SCALE),
                                       new Point(109/SCALE, 130/SCALE)
                                   };
            irContinents[28] = new List<Point>
                                   {
                                       new Point(59/SCALE, 41/SCALE),
                                       new Point(47/SCALE, 68/SCALE),
                                       new Point(47/SCALE, 73/SCALE),
                                       new Point(54/SCALE, 73/SCALE),
                                       new Point(62/SCALE, 80/SCALE),
                                       new Point(60/SCALE, 87/SCALE),
                                       new Point(59/SCALE, 94/SCALE),
                                       new Point(68/SCALE, 97/SCALE),
                                       new Point(73/SCALE, 100/SCALE),
                                       new Point(71/SCALE, 102/SCALE),
                                       new Point(67/SCALE, 102/SCALE),
                                       new Point(77/SCALE, 112/SCALE),
                                       new Point(72/SCALE, 117/SCALE),
                                       new Point(69/SCALE, 115/SCALE),
                                       new Point(67/SCALE, 117/SCALE),
                                       new Point(68/SCALE, 118/SCALE),
                                       new Point(74/SCALE, 121/SCALE),
                                       new Point(80/SCALE, 121/SCALE),
                                       new Point(85/SCALE, 127/SCALE),
                                       new Point(101/SCALE, 127/SCALE),
                                       new Point(107/SCALE, 125/SCALE),
                                       new Point(112/SCALE, 127/SCALE),
                                       new Point(109/SCALE, 130/SCALE),
                                       new Point(131/SCALE, 128/SCALE),
                                       new Point(136/SCALE, 121/SCALE),
                                       new Point(152/SCALE, 121/SCALE),
                                       new Point(162/SCALE, 117/SCALE),
                                       new Point(167/SCALE, 118/SCALE),
                                       new Point(173/SCALE, 114/SCALE),
                                       new Point(161/SCALE, 110/SCALE),
                                       new Point(161/SCALE, 103/SCALE),
                                       new Point(153/SCALE, 99/SCALE),
                                       new Point(153/SCALE, 89/SCALE),
                                       new Point(146/SCALE, 81/SCALE),
                                       new Point(143/SCALE, 72/SCALE),
                                       new Point(135/SCALE, 73/SCALE),
                                       new Point(129/SCALE, 71/SCALE),
                                       new Point(125/SCALE, 73/SCALE),
                                       new Point(130/SCALE, 58/SCALE),
                                       new Point(136/SCALE, 57/SCALE),
                                       new Point(134/SCALE, 39/SCALE),
                                       new Point(129/SCALE, 29/SCALE),
                                       new Point(128/SCALE, 23/SCALE),
                                       new Point(124/SCALE, 19/SCALE),
                                       new Point(114/SCALE, 29/SCALE),
                                       new Point(107/SCALE, 32/SCALE),
                                       new Point(97/SCALE, 43/SCALE),
                                       new Point(88/SCALE, 43/SCALE),
                                       new Point(86/SCALE, 47/SCALE),
                                       new Point(61/SCALE, 42/SCALE)
                                   };
            irContinents[29] = new List<Point>
                                   {
                                       new Point(124/SCALE, 19/SCALE),
                                       new Point(128/SCALE, 23/SCALE),
                                       new Point(129/SCALE, 29/SCALE),
                                       new Point(134/SCALE, 39/SCALE),
                                       new Point(136/SCALE, 57/SCALE),
                                       new Point(130/SCALE, 58/SCALE),
                                       new Point(125/SCALE, 73/SCALE),
                                       new Point(129/SCALE, 71/SCALE),
                                       new Point(135/SCALE, 73/SCALE),
                                       new Point(143/SCALE, 72/SCALE),
                                       new Point(146/SCALE, 81/SCALE),
                                       new Point(153/SCALE, 89/SCALE),
                                       new Point(153/SCALE, 99/SCALE),
                                       new Point(161/SCALE, 103/SCALE),
                                       new Point(161/SCALE, 110/SCALE),
                                       new Point(173/SCALE, 114/SCALE),
                                       new Point(177/SCALE, 119/SCALE),
                                       new Point(180/SCALE, 114/SCALE),
                                       new Point(187/SCALE, 114/SCALE),
                                       new Point(187/SCALE, 114/SCALE),
                                       new Point(188/SCALE, 109/SCALE),
                                       new Point(181/SCALE, 104/SCALE),
                                       new Point(175/SCALE, 94/SCALE),
                                       new Point(176/SCALE, 90/SCALE),
                                       new Point(172/SCALE, 85/SCALE),
                                       new Point(176/SCALE, 69/SCALE),
                                       new Point(172/SCALE, 61/SCALE),
                                       new Point(164/SCALE, 54/SCALE),
                                       new Point(160/SCALE, 52/SCALE),
                                       new Point(155/SCALE, 47/SCALE),
                                       new Point(150/SCALE, 45/SCALE),
                                       new Point(150/SCALE, 40/SCALE),
                                       new Point(159/SCALE, 35/SCALE),
                                       new Point(154/SCALE, 23/SCALE),
                                       new Point(157/SCALE, 20/SCALE),
                                       new Point(157/SCALE, 17/SCALE),
                                       new Point(149/SCALE, 7/SCALE),
                                       new Point(141/SCALE, 6/SCALE),
                                       new Point(131/SCALE, 14/SCALE),
                                       new Point(127/SCALE, 15/SCALE)
                                   };
            irContinents[30] = new List<Point>
                                   {
                                       new Point(196/SCALE, 0/SCALE),
                                       new Point(192/SCALE, 5/SCALE),
                                       new Point(193/SCALE, 12/SCALE),
                                       new Point(197/SCALE, 17/SCALE),
                                       new Point(197/SCALE, 20/SCALE),
                                       new Point(192/SCALE, 18/SCALE),
                                       new Point(192/SCALE, 25/SCALE),
                                       new Point(188/SCALE, 37/SCALE),
                                       new Point(189/SCALE, 28/SCALE),
                                       new Point(182/SCALE, 22/SCALE),
                                       new Point(179/SCALE, 25/SCALE),
                                       new Point(179/SCALE, 34/SCALE),
                                       new Point(176/SCALE, 39/SCALE),
                                       new Point(180/SCALE, 58/SCALE),
                                       new Point(180/SCALE, 68/SCALE),
                                       new Point(183/SCALE, 71/SCALE),
                                       new Point(187/SCALE, 89/SCALE),
                                       new Point(197/SCALE, 97/SCALE),
                                       new Point(204/SCALE, 98/SCALE),
                                       new Point(215/SCALE, 101/SCALE),
                                       new Point(229/SCALE, 102/SCALE),
                                       new Point(238/SCALE, 113/SCALE),
                                       new Point(250/SCALE, 120/SCALE),
                                       new Point(268/SCALE, 128/SCALE),
                                       new Point(296/SCALE, 132/SCALE),
                                       new Point(328/SCALE, 123/SCALE),
                                       new Point(370/SCALE, 105/SCALE),
                                       new Point(365/SCALE, 89/SCALE),
                                       new Point(360/SCALE, 78/SCALE),
                                       new Point(357/SCALE, 51/SCALE),
                                       new Point(359/SCALE, 48/SCALE),
                                       new Point(354/SCALE, 31/SCALE),
                                       new Point(360/SCALE, 19/SCALE),
                                       new Point(354/SCALE, 16/SCALE),
                                       new Point(348/SCALE, 14/SCALE),
                                       new Point(347/SCALE, 8/SCALE),
                                       new Point(344/SCALE, 12/SCALE),
                                       new Point(338/SCALE, 3/SCALE),
                                       new Point(331/SCALE, 3/SCALE),
                                       new Point(330/SCALE, 12/SCALE),
                                       new Point(323/SCALE, 1/SCALE)
                                   };
            irContinents[31] = new List<Point>
                                   {
                                       new Point(181/SCALE, 419/SCALE),
                                       new Point(200/SCALE, 437/SCALE),
                                       new Point(196/SCALE, 430/SCALE),
                                       new Point(203/SCALE, 432/SCALE),
                                       new Point(202/SCALE, 426/SCALE),
                                       new Point(210/SCALE, 430/SCALE),
                                       new Point(208/SCALE, 417/SCALE),
                                       new Point(212/SCALE, 411/SCALE),
                                       new Point(223/SCALE, 412/SCALE),
                                       new Point(223/SCALE, 417/SCALE),
                                       new Point(213/SCALE, 419/SCALE),
                                       new Point(224/SCALE, 426/SCALE),
                                       new Point(232/SCALE, 425/SCALE),
                                       new Point(238/SCALE, 431/SCALE),
                                       new Point(249/SCALE, 423/SCALE),
                                       new Point(257/SCALE, 423/SCALE),
                                       new Point(260/SCALE, 432/SCALE),
                                       new Point(275/SCALE, 448/SCALE),
                                       new Point(277/SCALE, 452/SCALE),
                                       new Point(281/SCALE, 452/SCALE),
                                       new Point(283/SCALE, 461/SCALE),
                                       new Point(283/SCALE, 468/SCALE),
                                       new Point(291/SCALE, 469/SCALE),
                                       new Point(292/SCALE, 478/SCALE),
                                       new Point(297/SCALE, 481/SCALE),
                                       new Point(302/SCALE, 495/SCALE),
                                       new Point(312/SCALE, 507/SCALE),
                                       new Point(316/SCALE, 515/SCALE),
                                       new Point(326/SCALE, 520/SCALE),
                                       new Point(341/SCALE, 521/SCALE),
                                       new Point(357/SCALE, 527/SCALE),
                                       new Point(360/SCALE, 526/SCALE),
                                       new Point(371/SCALE, 533/SCALE),
                                       new Point(371/SCALE, 537/SCALE),
                                       new Point(389/SCALE, 547/SCALE),
                                       new Point(402/SCALE, 549/SCALE),
                                       new Point(406/SCALE, 554/SCALE),
                                       new Point(415/SCALE, 560/SCALE),
                                       new Point(424/SCALE, 559/SCALE),
                                       new Point(436/SCALE, 556/SCALE),
                                       new Point(443/SCALE, 562/SCALE),
                                       new Point(452/SCALE, 562/SCALE),
                                       new Point(457/SCALE, 564/SCALE),
                                       new Point(470/SCALE, 553/SCALE),
                                       new Point(475/SCALE, 547/SCALE),
                                       new Point(485/SCALE, 547/SCALE),
                                       new Point(488/SCALE, 541/SCALE),
                                       new Point(493/SCALE, 533/SCALE),
                                       new Point(498/SCALE, 533/SCALE),
                                       new Point(509/SCALE, 525/SCALE),
                                       new Point(527/SCALE, 525/SCALE),
                                       new Point(541/SCALE, 528/SCALE),
                                       new Point(547/SCALE, 539/SCALE),
                                       new Point(549/SCALE, 555/SCALE),
                                       new Point(558/SCALE, 572/SCALE),
                                       new Point(562/SCALE, 579/SCALE),
                                       new Point(581/SCALE, 580/SCALE),
                                       new Point(585/SCALE, 582/SCALE),
                                       new Point(589/SCALE, 581/SCALE),
                                       new Point(596/SCALE, 585/SCALE),
                                       new Point(604/SCALE, 581/SCALE),
                                       new Point(613/SCALE, 580/SCALE),
                                       new Point(620/SCALE, 582/SCALE),
                                       new Point(625/SCALE, 580/SCALE),
                                       new Point(638/SCALE, 587/SCALE),
                                       new Point(636/SCALE, 579/SCALE),
                                       new Point(651/SCALE, 580/SCALE),
                                       new Point(656/SCALE, 580/SCALE),
                                       new Point(669/SCALE, 581/SCALE),
                                       new Point(674/SCALE, 577/SCALE),
                                       new Point(678/SCALE, 579/SCALE),
                                       new Point(694/SCALE, 579/SCALE),
                                       new Point(696/SCALE, 573/SCALE),
                                       new Point(702/SCALE, 580/SCALE),
                                       new Point(710/SCALE, 580/SCALE),
                                       new Point(724/SCALE, 579/SCALE),
                                       new Point(736/SCALE, 578/SCALE),
                                       new Point(734/SCALE, 572/SCALE),
                                       new Point(739/SCALE, 574/SCALE),
                                       new Point(745/SCALE, 573/SCALE),
                                       new Point(748/SCALE, 580/SCALE),
                                       new Point(752/SCALE, 581/SCALE),
                                       new Point(754/SCALE, 577/SCALE),
                                       new Point(762/SCALE, 575/SCALE),
                                       new Point(762/SCALE, 572/SCALE),
                                       new Point(768/SCALE, 570/SCALE),
                                       new Point(769/SCALE, 573/SCALE),
                                       new Point(773/SCALE, 572/SCALE),
                                       new Point(777/SCALE, 566/SCALE),
                                       new Point(798/SCALE, 564/SCALE),
                                       new Point(805/SCALE, 560/SCALE),
                                       new Point(805/SCALE, 599/SCALE),
                                       new Point(529/SCALE, 600/SCALE),
                                       new Point(527/SCALE, 593/SCALE),
                                       new Point(523/SCALE, 593/SCALE),
                                       new Point(523/SCALE, 587/SCALE),
                                       new Point(527/SCALE, 589/SCALE),
                                       new Point(526/SCALE, 583/SCALE),
                                       new Point(529/SCALE, 577/SCALE),
                                       new Point(529/SCALE, 568/SCALE),
                                       new Point(526/SCALE, 564/SCALE),
                                       new Point(529/SCALE, 559/SCALE),
                                       new Point(524/SCALE, 559/SCALE),
                                       new Point(522/SCALE, 567/SCALE),
                                       new Point(516/SCALE, 567/SCALE),
                                       new Point(512/SCALE, 572/SCALE),
                                       new Point(511/SCALE, 588/SCALE),
                                       new Point(498/SCALE, 599/SCALE),
                                       new Point(448/SCALE, 600/SCALE),
                                       new Point(418/SCALE, 609/SCALE),
                                       new Point(412/SCALE, 615/SCALE),
                                       new Point(390/SCALE, 611/SCALE),
                                       new Point(381/SCALE, 600/SCALE),
                                       new Point(322/SCALE, 600/SCALE),
                                       new Point(317/SCALE, 594/SCALE),
                                       new Point(309/SCALE, 600/SCALE),
                                       new Point(233/SCALE, 600/SCALE),
                                       new Point(234/SCALE, 554/SCALE),
                                       new Point(238/SCALE, 547/SCALE),
                                       new Point(236/SCALE, 541/SCALE),
                                       new Point(223/SCALE, 539/SCALE),
                                       new Point(220/SCALE, 532/SCALE),
                                       new Point(211/SCALE, 517/SCALE),
                                       new Point(203/SCALE, 510/SCALE),
                                       new Point(208/SCALE, 508/SCALE),
                                       new Point(199/SCALE, 500/SCALE),
                                       new Point(199/SCALE, 495/SCALE),
                                       new Point(193/SCALE, 488/SCALE),
                                       new Point(186/SCALE, 481/SCALE),
                                       new Point(183/SCALE, 467/SCALE),
                                       new Point(178/SCALE, 466/SCALE),
                                       new Point(174/SCALE, 470/SCALE),
                                       new Point(169/SCALE, 465/SCALE),
                                       new Point(174/SCALE, 459/SCALE)
                                   };
            irContinents[32] = new List<Point>
                                   {
                                       new Point(666/SCALE, 19/SCALE),
                                       new Point(756/SCALE, 19/SCALE),
                                       new Point(756/SCALE, 49/SCALE),
                                       new Point(666/SCALE, 49/SCALE)
                                   };
            irContinents[33] = new List<Point>
                                   {
                                       new Point(35/SCALE, 555/SCALE),
                                       new Point(125/SCALE, 555/SCALE),
                                       new Point(125/SCALE, 585/SCALE),
                                       new Point(35/SCALE, 585/SCALE)
                                   };
            //irContinents[36] = new List<Point>();
            //irContinents[36].Add(new Point(35 / SCALE, 555 / SCALE));
            //irContinents[36].Add(new Point(125 / SCALE, 555 / SCALE));
            //irContinents[36].Add(new Point(125 / SCALE, 585 / SCALE));
            //irContinents[36].Add(new Point(35 / SCALE, 585 / SCALE));
        }

        #endregion
    }
}
