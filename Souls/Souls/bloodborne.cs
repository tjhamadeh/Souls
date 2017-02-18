using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Souls
{
    class BLOODBORNE
    {
        public BBClass selClass;
        public MILQUETOAST mtBase;
        public LONESURVIVOR lsBase;
        public TROUBLEDCHILDHOOD tcBase;
        public VIOLENTPAST vpBase;
        public PROFESSIONAL prBase;
        public MILITARYVETERAN mvBase;
        public NOBLESCION nsBase;
        public CRUELFATE cfBase;
        public WASTEOFSKIN wsBase;
        public BLOODBORNE(int selectedClass)
        {
            switch ((BLOODBORNE_E)selectedClass)
            {
                case BLOODBORNE_E.MILQUETOAST:
                    mtBase = new MILQUETOAST();
                    selClass = mtBase;
                    break;
                case BLOODBORNE_E.LONESURVIVOR:
                    lsBase = new LONESURVIVOR();
                    selClass = lsBase;
                    break;
                case BLOODBORNE_E.TROUBLEDCHILDHOOD:
                    tcBase = new TROUBLEDCHILDHOOD();
                    selClass = tcBase;
                    break;
                case BLOODBORNE_E.VIOLENTPAST:
                    vpBase = new VIOLENTPAST();
                    selClass = vpBase;
                    break;
                case BLOODBORNE_E.PROFESSIONAL:
                    prBase = new PROFESSIONAL();
                    selClass = prBase;
                    break;
                case BLOODBORNE_E.MILITARYVETERAN:
                    mvBase = new MILITARYVETERAN();
                    selClass = mvBase;
                    break;
                case BLOODBORNE_E.NOBLESCION:
                    nsBase = new NOBLESCION();
                    selClass = nsBase;
                    break;
                case BLOODBORNE_E.CRUELFATE:
                    cfBase = new CRUELFATE();
                    selClass = cfBase;
                    break;
                case BLOODBORNE_E.WASTEOFSKIN:
                    wsBase = new WASTEOFSKIN();
                    selClass = wsBase;
                    break;
            }
        }
        public abstract class BBClass
        {
            public abstract int getLvl();
            public abstract int getStr();
            public abstract int getSkl();
        }
        public class MILQUETOAST : BBClass
        {
            private int lvl;
            private int str;
            private int skl;
            public MILQUETOAST()
            {
                lvl = 10;
                str = 12;
                skl = 10;
            }
            public override int getLvl()
            {
                return lvl;
            }
            public override int getStr()
            {
                return str;
            }
            public override int getSkl()
            {
                return skl;
            }
        }
        public class LONESURVIVOR : BBClass
        {
            private int lvl;
            private int str;
            private int skl;
            public LONESURVIVOR()
            {
                lvl = 10;
                str = 11;
                skl = 10;
            }
            public override int getLvl()
            {
                return lvl;
            }
            public override int getStr()
            {
                return str;
            }
            public override int getSkl()
            {
                return skl;
            }
        }
        public class TROUBLEDCHILDHOOD : BBClass
        {
            private int lvl;
            private int str;
            private int skl;
            public TROUBLEDCHILDHOOD()
            {
                lvl = 10;
                str = 9;
                skl = 13;
            }
            public override int getLvl()
            {
                return lvl;
            }
            public override int getStr()
            {
                return str;
            }
            public override int getSkl()
            {
                return skl;
            }
        }
        public class VIOLENTPAST : BBClass
        {
            private int lvl;
            private int str;
            private int skl;
            public VIOLENTPAST()
            {
                lvl = 10;
                str = 15;
                skl = 9;
            }
            public override int getLvl()
            {
                return lvl;
            }
            public override int getStr()
            {
                return str;
            }
            public override int getSkl()
            {
                return skl;
            }
        }
        public class PROFESSIONAL : BBClass
        {
            private int lvl;
            private int str;
            private int skl;
            public PROFESSIONAL()
            {
                lvl = 10;
                str = 9;
                skl = 15;
            }
            public override int getLvl()
            {
                return lvl;
            }
            public override int getStr()
            {
                return str;
            }
            public override int getSkl()
            {
                return skl;
            }
        }
        public class MILITARYVETERAN : BBClass
        {
            private int lvl;
            private int str;
            private int skl;
            public MILITARYVETERAN()
            {
                lvl = 10;
                str = 14;
                skl = 13;
            }
            public override int getLvl()
            {
                return lvl;
            }
            public override int getStr()
            {
                return str;
            }
            public override int getSkl()
            {
                return skl;
            }
        }
        public class NOBLESCION : BBClass
        {
            private int lvl;
            private int str;
            private int skl;
            public NOBLESCION()
            {
                lvl = 10;
                str = 9;
                skl = 13;
            }
            public override int getLvl()
            {
                return lvl;
            }
            public override int getStr()
            {
                return str;
            }
            public override int getSkl()
            {
                return skl;
            }
        }
        public class CRUELFATE : BBClass
        {
            private int lvl;
            private int str;
            private int skl;
            public CRUELFATE()
            {
                lvl = 10;
                str = 10;
                skl = 9;
            }
            public override int getLvl()
            {
                return lvl;
            }
            public override int getStr()
            {
                return str;
            }
            public override int getSkl()
            {
                return skl;
            }
        }
        public class WASTEOFSKIN : BBClass
        {
            private int lvl;
            private int str;
            private int skl;
            public WASTEOFSKIN()
            {
                lvl = 4;
                str = 10;
                skl = 9;
            }
            public override int getLvl()
            {
                return lvl;
            }
            public override int getStr()
            {
                return str;
            }
            public override int getSkl()
            {
                return skl;
            }
        }
    }
}
