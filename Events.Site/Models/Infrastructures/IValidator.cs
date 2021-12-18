using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Site.Models.Infrastructures
{
	public interface IValidator
	{
		bool IsValid(string value);
	}
}
