﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodanalyser
{

    internal class CustomException
    {
        string message;
        public CustomException(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw (new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty"));
                }

                else if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                return "happy";

            }
        }
    }
}

    



