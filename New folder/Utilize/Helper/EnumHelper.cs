using System;
using System.ComponentModel;

namespace Utilize.Helper
{
	#region Enum English Alphabet
	
	public enum EnglishAlphabet
	{
		[Description("A")]
		A = 0,

		[Description("B")]
		B = 1,

		[Description("C")]
		C = 2,

		[Description("D")]
		D = 3,

		[Description("E")]
		E = 4,

		[Description("F")]
		F = 5,

		[Description("G")]
		G = 6,

		[Description("H")]
		H = 7,

		[Description("I")]
		I = 8,

		[Description("J")]
		J = 9,

		[Description("K")]
		K = 10,

		[Description("L")]
		L = 11,

		[Description("M")]
		M = 12,

		[Description("N")]
		N = 13,

		[Description("O")]
		O = 14,

		[Description("P")]
		P = 15,

		[Description("Q")]
		Q = 16,

		[Description("R")]
		R = 17,

		[Description("S")]
		S = 18,

		[Description("T")]
		T = 19,

		[Description("U")]
		U = 20,

		[Description("V")]
		V = 21,

		[Description("W")]
		W = 22,

		[Description("X")]
		X = 23,

		[Description("Y")]
		Y = 24,

		[Description("Z")]
		Z = 25
	}

	#endregion

    public static class EnaumHelper
    {
        public static string GetDescription(this Enum en)
        {

            var type = en.GetType();

            var memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {

                var attrs = memInfo[0].GetCustomAttributes(false);

                if (attrs != null && attrs.Length > 0)

                    return ((DescriptionAttribute) attrs[0]).Description;

            }

            return en.ToString();

        }
    }
}
