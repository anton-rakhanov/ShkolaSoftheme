using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateHandlerLibrary
{
    public class ZodiacExplorer
    {
        public static string DetermineZodiacSign(DateTime birthDate)
        {
            switch (birthDate.Month)
            {
                case 1:
                    {
                        if(birthDate.Day <= 20)
                        {
                            return "capricorn";
                        }
                        else
                        {
                            return "aquarius";
                        }
                    }
                case 2:
                    {
                        if (birthDate.Day <= 20)
                        {
                            return "aquarius";
                        }
                        else
                        {
                            return "pisces";
                        }
                    }
                case 3:
                    {
                        if (birthDate.Day <= 20)
                        {
                            return "pisces";
                        }
                        else
                        {
                            return "aries";
                        }
                    }
                case 4:
                    {
                        if (birthDate.Day <= 20)
                        {
                            return "aries";
                        }
                        else
                        {
                            return "taurus";
                        }
                    }
                case 5:
                    {
                        if (birthDate.Day <= 20)
                        {
                            return "taurus";
                        }
                        else
                        {
                            return "gemini";
                        }
                    }
                case 6:
                    {
                        if (birthDate.Day <= 21)
                        {
                            return "gemini";
                        }
                        else
                        {
                            return "cancer";
                        }
                    }
                case 7:
                    {
                        if (birthDate.Day <= 22)
                        {
                            return "cancer";
                        }
                        else
                        {
                            return "leo";
                        }
                    }
                case 8:
                    {
                        if (birthDate.Day <= 23)
                        {
                            return "leo";
                        }
                        else
                        {
                            return "virgo";
                        }
                    }
                case 9:
                    {
                        if (birthDate.Day <= 23)
                        {
                            return "virgo";
                        }
                        else
                        {
                            return "libra";
                        }
                    }
                case 10:
                    {
                        if (birthDate.Day <= 23)
                        {
                            return "libra";
                        }
                        else
                        {
                            return "scorpio";
                        }
                    }
                case 11:
                    {
                        if (birthDate.Day <= 22)
                        {
                            return "scorpio";
                        }
                        else
                        {
                            return "sagittarius";
                        }
                    }
                case 12:
                    {
                        if (birthDate.Day <= 21)
                        {
                            return "sagittarius";
                        }
                        else
                        {
                            return "capricorn";
                        }
                    }
                default:
                    {
                        Console.WriteLine("You don't have zodiac sign..");
                        return null;
                    }
            }
        }
    }
}
