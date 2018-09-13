using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EF
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model2 m = new Model2();
            Advertise adv = new Advertise
            {
                Title = ""
            };
            m.Advertise.Add(adv);
            m.Advertise.Remove(adv);
            m.Advertise.Count();

            var advs = (from t in m.Advertise
                       where t.Id==2
                       select t).First();

            advs.Intro = "dsfsf";

            m.SaveChanges();
            
        }
    }
}