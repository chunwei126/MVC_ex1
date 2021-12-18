using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Events.Site.Models.Infrastructures
{
	public class RequiredValidator : IValidator
	{
		public bool IsValid(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new Exception("必填");
			}
			else
			{
				return true;
			}
		}
	}
}