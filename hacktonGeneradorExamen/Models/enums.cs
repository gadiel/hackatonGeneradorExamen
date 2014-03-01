using System.Linq;
using System.Web;
using System.Web.UI;

namespace hacktonGeneradorExamen.Models
{

    public enum QuestionFormat
    {
        TrueFalse,
        MultiChoice,
        MultipleResponse
    }

    public enum QuestionType
    {
        Image,
        Text,
        Sound
    }
}