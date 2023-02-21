using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridMAUI
{
    public class ViewModel : INotifyPropertyChanged
    {
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ViewModel()
        {
            SetRowstoGenerate(200);
        }

        #region ItemsSource

        private ObservableCollection<OrderInfo> ordersInfo;

        public ObservableCollection<OrderInfo> OrdersInfo
        {
            get { return ordersInfo; }
            set { this.ordersInfo = value; }
        }

        #endregion

        #region ItemSource Generator

        public void SetRowstoGenerate(int count)
        {
            OrderInfoRepository order = new OrderInfoRepository();
            ordersInfo = order.GetOrderDetails(100);
        }

        #endregion
    }
}
