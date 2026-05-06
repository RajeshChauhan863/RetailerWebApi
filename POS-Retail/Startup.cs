using BAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository;
using UnitofWork;

namespace POS_Retail
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddControllersWithViews();
            services.AddDbContext<PosRetailContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitofWork, Unitofwork>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerRepository<Customer>, CustomerRepository>();
            services.AddScoped<IinventoryService, InventoryService>();
            services.AddScoped<IinventoryRepository<Inventory>, InventoryRepository>();
            services.AddScoped<IProductService,ProductService>();
            services.AddScoped<IProductRepository<Product>, ProductRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository<Category>, CategoryRepository>();

            services.AddScoped<IPurchaseOrderService, PurchaseOrderService>();
            services.AddScoped<IPurchaseOrderRepository<PurchaseOrder>, PurchaseOrderRepository>();

            services.AddScoped<IPurchaseOrderDetailService, PurchaseOrderDetailService>();
            services.AddScoped<IPurchaseOrderDetailRepository<PurchaseOrderDetail>, PurchaseOrderDetailRepository>();

            services.AddScoped<ISalesOrderService, SalesOrderService>();
            services.AddScoped<ISalesOrderRepository<SalesOrder>, SalesOrderRepository>();

            services.AddScoped<ISalesOrderDetailService, SalesOrderDetailService>();
            services.AddScoped<ISalesOrderDetailRepository<SalesOrderDetail>, SalesOrderDetailRepository>();

            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<ISupplierRepository<Supplier>, SupplierRepository>();

            services.AddScoped<IWareHouseService, WareHouseService>();
            services.AddScoped<IWareHouseRepository<WareHouse>, WareHouseRepository>();
        
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {

                app.UseDeveloperExceptionPage();
            }

            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            
           
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
        }
    }
}