using LBibApi.Repositories;
using LBibApi.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IAutorRepository, AutorRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddTransient<IEditoraRepository, EditoraRepository>();
builder.Services.AddTransient<IEmprestimoRepository, EmprestimoRepository>();
builder.Services.AddTransient<ILivroRepository, LivroRepository>();
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();

var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
