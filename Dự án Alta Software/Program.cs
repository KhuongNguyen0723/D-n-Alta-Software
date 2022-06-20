
using Dự_án_Alta_Software.Data;
using Dự_án_Alta_Software.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ITaiKhoan, TaiKhoanRepository>();
builder.Services.AddTransient<ITaiLieu, TaiLieuRepository>();
builder.Services.AddTransient<IPhanQuyen, PhanQuyenRepository>();
builder.Services.AddTransient<IMonHoc, MonHocRepository>();
builder.Services.AddTransient<ILoaiTaiLieucs, LoaiTaiLieuRepository>();
builder.Services.AddTransient<IPhanCong, PhanCongRepository>();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AltaSoftware"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(/*c => { c.SwaggerEndpoint("/swager/v1/swagger.json", "Dự án Alta Software v1"); }*/);
}
//app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swager/v1/swagger.json", "Dự án Alta Software v1"); });

app.UseHttpsRedirection();

app.UseRouting();


app.UseAuthorization();

app.MapControllers();

app.UseEndpoints(Endpoints =>{ Endpoints.MapControllers(); });

app.Run();
