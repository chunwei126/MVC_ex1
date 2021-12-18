namespace Events.Site.Models.EFModels
{
	using Events.Site.Models.Infrastructures;
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	public partial class Register
	{
		public List<IValidator> Validators { get; set; }
		public int Id { get; set; }

		private string name;
		public string Name
		{
			get { return name; }

			set
			{
				foreach (IValidator validator in Validators)
				{
					if (validator.IsValid(value) == false) throw new Exception("沒有通過驗證");
				}

				name = value;
			}
		}

		private string email;
		public string Email
		{
			get { return email; }

			set
			{
				foreach (IValidator validator in Validators)
				{
					if (validator.IsValid(value) == false) throw new Exception("沒有通過驗證");
				}

				email = value;
			}
		}

		private DateTime createTime;
		public DateTime CreateTime
		{
			get { return createTime; }

			set
			{
				createTime = DateTime.Now;
			}
		}
	}
}
