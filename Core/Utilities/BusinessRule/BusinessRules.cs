﻿using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.BusinessRule
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)//burada logics iş kuralları array inin ismi
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }

            return null;
        }
    }
}
