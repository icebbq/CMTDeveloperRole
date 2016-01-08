using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using CMTDeveloperRole.StringProcessor;

namespace CMTDeveloperRole.Demo
{
    public class DemoWindowViewModel : ViewModelBase
    {
        [ImportMany(typeof(IStringProcessor))]
        private IEnumerable<IStringProcessor> _processors;

        public DemoWindowViewModel()
        {
            App.MEFContainer.ComposeParts(this);

            ProcessorList = new ObservableCollection<IStringProcessor>();
            foreach (var proc in _processors)
            {
                ProcessorList.Add(proc);
            }

            SelectedProcessor = _processors.FirstOrDefault();
        }

        private string _inputText;
        public string InputText
        {
            get
            {
                return _inputText;
            }
            set
            {
                if (SetProperty(ref _inputText, value))
                    Process(_inputText);
            }
        }

        private ProcessResult _procResult;
        public ProcessResult ProcessResult
        {
            get
            {
                return _procResult;
            }
            private set
            {
                SetProperty(ref _procResult, value);
            }
        }

        public ObservableCollection<IStringProcessor> ProcessorList { get; private set; }

        private IStringProcessor _selectedProc;
        public IStringProcessor SelectedProcessor
        {
            get { return _selectedProc; }
            set
            {
                if (SetProperty(ref _selectedProc, value))
                    Process(_inputText);
            }
        }

        private void Process(string input)
        {
            if(SelectedProcessor != null)
            {
                ProcessResult = SelectedProcessor.Process(InputText);
            }
        }
    }
}
