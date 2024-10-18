var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    string name = "Карамышев Максим";
    string group = "Группа 1В";
    string description = "Это пример страницы с информацией о пользователе.";

    string msg = $@"
        <html>
            <head>
                <meta charset='UTF-8'>
                <title>Информация о пользователе</title>
                <style>
                    body {{ font-family: Arial, sans-serif; text-align: center; margin-top: 50px; }}
                    h1 {{ color: #2c3e50; }}
                    h3 {{ color: #16a085; }}
                    p {{ color: #7f8c8d; }}
                </style>
            </head>
            <body>
                <h1>{name}</h1>
                <h3>{group}</h3>
                <p>{description}</p>
            </body>
        </html>";
    return Results.Text(msg, "text/html");
});

app.MapGet("/name", () =>
{
    string name = "Карамышев Максим";
    string msg = $@"
        <html>
            <head>
                <meta charset='UTF-8'>
                <title>Имя пользователя</title>
                <style>
                    body {{ font-family: Arial, sans-serif; text-align: center; margin-top: 50px; }}
                    h1 {{ color: #2c3e50; }}
                </style>
            </head>
            <body>
                <h1>{name}</h1>
            </body>
        </html>";
    return Results.Text(msg, "text/html");
});

app.MapGet("/group", () =>
{
    string group = "Группа 1В";
    string msg = $@"
        <html>
            <head>
                <meta charset='UTF-8'>
                <title>Номер группы</title>
                <style>
                    body {{ font-family: Arial, sans-serif; text-align: center; margin-top: 50px; }}
                    h1 {{ color: #2c3e50; }}
                </style>
            </head>
            <body>
                <h1>{group}</h1>
            </body>
        </html>";

    return Results.Text(msg, "text/html");
});

app.MapGet("/about", () =>
{
    string description = "Это пример страницы с информацией о пользователе.";
    string msg = $@"
        <html>
            <head>
                <meta charset='UTF-8'>
                <title>О пользователе</title>
                <style>
                    body {{ font-family: Arial, sans-serif; text-align: center; margin-top: 50px; }}
                    p {{ color: #7f8c8d; }}
                </style>
            </head>
            <body>
                <p>{description}</p>
            </body>
        </html>";

    return Results.Text(msg, "text/html");
});

app.Run();
