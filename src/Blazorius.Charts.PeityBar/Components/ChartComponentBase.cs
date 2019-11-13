using Blazorius.Charts.Peity.Models;
using Blazorius.Charts.Peity.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorius.Charts.Peity.Components
{
    public class ChartComponentBase<TOptions> : ComponentBase where TOptions : OptionsBase, new()
    {
        private IEnumerable<int> data;

        public ChartComponentBase()
        {
            this.Options = new TOptions();
            this.Options.PropertyChanged += (s, e) => StateHasChanged();
        }

        [Inject] public IPeityInterop PeityInterop { get; set; }

        public Guid Id { get; set; } = Guid.NewGuid();
        [Parameter]
        public IEnumerable<int> Data
        {
            get => data;
            set
            {
                data = value;
                StateHasChanged();
                if (value is INotifyCollectionChanged observable)
                    observable.CollectionChanged += (s, e) => StateHasChanged();
            }
        }

        public TOptions Options { get; }

        [Parameter] public int? Height { get => Options.Height; set => Options.Height = value; }

        [Parameter] public int? Width { get => Options.Width; set => Options.Width = value; }

        [Parameter] public string Color { get => Options.Fill?.FirstOrDefault(); set => Options.Fill = new[] { value }; }

        [Parameter] public string[] Fill { get => Options.Fill; set => Options.Fill = value; }

        public virtual ChartType Type { get; }

        public virtual async Task UpdateViewAsync()
        {
            await PeityInterop.InitAsync(Type, "#" + Id, Options);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
                await UpdateViewAsync();

            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
