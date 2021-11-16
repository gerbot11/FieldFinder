using FieldFinder.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace FieldFinder.API
{
    public interface IFieldService
    {
        Task<FieldDetailModel> GetDetailModelAsync(long id);
        Task<ObservableCollection<NearYouModel>> SetDataNearYou();
    }
}
