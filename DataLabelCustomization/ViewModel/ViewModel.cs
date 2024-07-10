using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLabelCustomization
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public List<Brush> CustomBrushes { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>();

            Data.Add(new Model("Audi", 7.25));
            Data.Add(new Model("Volkswagen", 5.5));
            Data.Add(new Model("Skoda", 6.5));
            Data.Add(new Model("Mercedese Benz", 7.5));
            Data.Add(new Model("BMW", 8.5));
            Data.Add(new Model("Rolls Royce", 5));
            Data.Add(new Model("Jaguar", 4.5));

            CustomBrushes = new List<Brush>();
            CustomBrushes.Add(new SolidColorBrush(Color.FromRgb(255, 159, 64)));  // Light Orange
            CustomBrushes.Add(new SolidColorBrush(Color.FromRgb(255, 205, 86)));  // Light Yellow
            CustomBrushes.Add(new SolidColorBrush(Color.FromRgb(75, 192, 192)));  // Light Cyan
            CustomBrushes.Add(new SolidColorBrush(Color.FromRgb(153, 102, 255))); // Light Purple
            CustomBrushes.Add(new SolidColorBrush(Color.FromRgb(255, 99, 132)));  // Light Pink
        }
    }
}
