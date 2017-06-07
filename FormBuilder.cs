using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
     interface UIBuilder<T>
    {
        T Build();
    }

    public class FormBuilder : UIBuilder<Form>
    {
        System.Windows.Forms.Form oForm;

        Form UIBuilder<Form>.Build()
        {
            throw new NotImplementedException();
        }
    }

}
