using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Events.Site.Models.Infrastructures
{
	public class MaxlengthValidator : IValidator
	{
		private readonly int maxlength;
		public MaxlengthValidator(int maxLength)
		{
			this.maxlength = maxLength;
		}

		public bool IsValid(string value)
		{
			if (value.Length > maxlength)
			{
				throw new Exception("長度不能超過" + maxlength);
			}

			return true;
		}
	}
}