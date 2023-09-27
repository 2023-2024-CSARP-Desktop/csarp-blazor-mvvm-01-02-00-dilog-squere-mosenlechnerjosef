using System.ComponentModel;

namespace ViewModels.BaseClass
{
    public interface IViewModelBase
    {
        public bool IsBusy { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
        }
    }
}
