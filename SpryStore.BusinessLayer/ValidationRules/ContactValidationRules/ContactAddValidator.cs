using FluentValidation;
using SpryStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryStore.BusinessLayer.ValidationRules.ContactValidationRules
{
    public class ContactAddValidator:AbstractValidator<Contact>
    {
        public ContactAddValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Ad soyad alanını boş geçemezsiniz");
            RuleFor(x => x.NameSurname).MinimumLength(5).WithMessage("Ad soyad alanını 5 karakterden fazla olmalıdır.");
            RuleFor(x => x.NameSurname).MaximumLength(30).WithMessage("Ad soyad alanını boş geçemezsiniz.");
            //RuleFor(x => x.NameSurname).Equal("a").WithMessage("Ad soyad alanınında a harfi olmalıdır.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj alanını boş geçmeyiniz.");
           
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanını boş geçmeyiniz.");
            
            RuleFor(x => x.Mail).MaximumLength(30).WithMessage("Mail alanı çok uzun.");
            RuleFor(x => x.Mail).MinimumLength(12).WithMessage("Mail alanını çok kısa.");
        }
    }
}
