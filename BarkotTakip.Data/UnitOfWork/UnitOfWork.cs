using BarkotTakip.Data.Context;
using BarkotTakip.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Data.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {

        #region Variable
        private readonly MarketBarkodDBEntities _contex;

        private  CategoriesRepository _categoriesRepository = null;
        private  CustomersRepository _customersRepository = null;
        private  EmployeesRepository _employeesRepository = null;
        private  OrdersRepository _ordersRepository = null;
        private ProductsRepository _productsRepository = null;
        private ProductsStockRepository _productStockRepository = null;
        private PurchaseOrderRepository _purchaseOrderRepository = null;
        private CustomerSummaryRepository _customerSummaryRepository = null;
        private InvoceRepository _invoceRepository = null;
        private OrderDetailsRepository _orderDetailsRepository = null;
        private SuppliersRepository _suppliesRepository = null;
        #endregion


        #region Ctor
        public UnitOfWork()
        {
            _contex = new MarketBarkodDBEntities();
        }

        #endregion

        #region Repository

        public SuppliersRepository SuppliesRepository
        {
            get
            {
                if (_suppliesRepository == null)
                {
                    _suppliesRepository = new SuppliersRepository(_contex);
                };
                return _suppliesRepository;
            }
        }
        public OrderDetailsRepository OrderDetailsRepository
        {
            get
            {
                if (_orderDetailsRepository == null)
                {
                    _orderDetailsRepository = new OrderDetailsRepository(_contex);
                };
                return _orderDetailsRepository;
            }
        }

        public InvoceRepository InvoceRepository
        {
            get
            {
                if (_invoceRepository == null)
                {
                    _invoceRepository = new InvoceRepository(_contex);
                };
                return _invoceRepository;
            }
        }

        public CustomerSummaryRepository CustomerSummaryRepository
        {
            get
            {
                if (_customerSummaryRepository == null)
                {
                    _customerSummaryRepository = new CustomerSummaryRepository(_contex);
                };
                return _customerSummaryRepository;
            }
        }

        public CategoriesRepository CategoriesRepository
        {
            get
            {
                if (_categoriesRepository == null)
                {
                    _categoriesRepository = new CategoriesRepository(_contex);
                }
                return _categoriesRepository;
            }
        }
        public CustomersRepository CustomersRepository
        {
            get
            {
                if (_customersRepository == null)
                {
                    _customersRepository = new CustomersRepository(_contex);
                }
                return _customersRepository;
            }
        }
        public EmployeesRepository EmployeesRepository
        {
            get
            {
                if (_employeesRepository == null)
                {
                    _employeesRepository = new EmployeesRepository(_contex);
                }
                return _employeesRepository;
            }
        }
        public OrdersRepository OrdersRepository
        {
            get
            {
                if (_ordersRepository == null)
                {
                    _ordersRepository = new OrdersRepository(_contex);
                }
                return _ordersRepository;
            }
        }
        public ProductsRepository ProductsRepository
        {
            get
            {
                if (_productsRepository == null)
                {
                    _productsRepository = new ProductsRepository(_contex);
                }
                return _productsRepository;
            }
        }

        public ProductsStockRepository ProductStockRepository
        {
            get
            {
                if (_productStockRepository == null)
                {
                    _productStockRepository = new ProductsStockRepository(_contex);
                }
                return _productStockRepository;
            }
        }
        public PurchaseOrderRepository PurchaseOrderRepository
        {
            get
            {
                if (_purchaseOrderRepository == null)
                {
                    _purchaseOrderRepository = new PurchaseOrderRepository(_contex);
                }
                return _purchaseOrderRepository;
            }
        }

        #endregion

        #region Transactions
        public void BeginTransaction()
        {
            _contex.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _contex.Database.CurrentTransaction.Commit();
        }

        public void RollbackTransaction()
        {
            _contex.Database.CurrentTransaction.Rollback();
        }

        public int SaveChanges()
        {
            try
            {
                return _contex.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region Disposable
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            disposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion
    }
}
