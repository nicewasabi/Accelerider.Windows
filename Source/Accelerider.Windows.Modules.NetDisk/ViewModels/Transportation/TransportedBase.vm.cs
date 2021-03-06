﻿using System.Collections.ObjectModel;
using Accelerider.Windows.Infrastructure.Interfaces;
using Microsoft.Practices.Unity;

namespace Accelerider.Windows.Modules.NetDisk.ViewModels.Transportation
{
    public abstract class TransportedBaseViewModel : ViewModelBase
    {
        private ObservableCollection<ITransferredFile> transferredFiles;


        protected TransportedBaseViewModel(IUnityContainer container) : base(container)
        {
            TransferredFiles = GetTransferredFiles();
        }


        public ObservableCollection<ITransferredFile> TransferredFiles
        {
            get => transferredFiles;
            set => SetProperty(ref transferredFiles, value);
        }

        protected abstract ObservableCollection<ITransferredFile> GetTransferredFiles();
    }
}
