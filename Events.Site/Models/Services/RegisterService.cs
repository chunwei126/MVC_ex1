using Events.Site.Models.EFModels;
using Events.Site.Models.Infrastructures;
using Events.Site.Models.Repositories;
using Events.Site.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Events.Site.Models.Services
{
	public class RegisterService
	{
		private RegisterRepository repo = new RegisterRepository();
		public void Create(RegisterCreateVM model)
		{
			Register register = new Register(); // new 出一個 DBModel

			List<IValidator> validators = new List<IValidator>() // 組合出所需的驗證方法
			{
				new RequiredValidator(),
				new MaxlengthValidator(200)
			};

			try
			{
				register.Validators = validators;
				register.Name = model.Name;
				register.Email = model.Email;

				repo.Create(register);
			}
			catch (Exception ex)
			{
				Console.WriteLine("NAME錯誤:" + ex.Message);
			}
		}

		public IEnumerable<Register> GetAll()
		{
			return repo.GetAll();
		}
	}
}