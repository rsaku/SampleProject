using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace BootStrapTest.Models
{
	public class SampleViewModel
	{
		public int Id { get; set; }
		[DisplayName("名前")]
		public string Name { get; set; }
		[DisplayName("誕生日")]
		[DataType(DataType.Date)]
		public DateTime BirthDay { get; set; }
		[DisplayName("性別")]
		public string Sex { get; set; }
		[DisplayName("国籍")]
		public string Country { get; set; }
		[DisplayName("削除")]
		public bool IsDelete { get; set; }

		// ドロップダウンリストの選択肢をセットします。
		public List<SectionViewModel> SexOptions { get; set; }
		public List<SectionViewModel> CountryOptions { get; set; }


		public SampleViewModel(string Name, DateTime BirthDay, string Sex, string Country, bool IsDelete)
		{
			this.Name = Name;
			this.BirthDay = BirthDay;
			this.Sex = Sex;
			this.Country = Country;
			this.IsDelete = IsDelete;

			this.SexOptions = new List<SectionViewModel>();
			SexOptions.Add(new SectionViewModel { Value = "1", DisplayText = "男" });
			SexOptions.Add(new SectionViewModel { Value = "2", DisplayText = "女" });


			this.CountryOptions = new List<SectionViewModel>();
			CountryOptions.Add(new SectionViewModel { Value = "1", DisplayText = "日本" });
			CountryOptions.Add(new SectionViewModel { Value = "2", DisplayText = "アメリカ" });
			CountryOptions.Add(new SectionViewModel { Value = "3", DisplayText = "イギリス" });
			CountryOptions.Add(new SectionViewModel { Value = "4", DisplayText = "イタリア" });
			CountryOptions.Add(new SectionViewModel { Value = "5", DisplayText = "ドイツ" });

		}
	}


	// ドロップダウンリストの選択肢を表す ViewModel です。
    public class SectionViewModel
    {
        // 選択肢の値をセットします。
		public string Value { get; set; }
        public string DisplayText { get; set; }
    }
	

}