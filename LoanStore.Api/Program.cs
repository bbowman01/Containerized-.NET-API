// Purpose: Entry point for the application. Configures the application and starts the server.

using Loans.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<LoansDto> loans = [
    new (
        1,
        "John Doe",
        250000,
        "Mortgage",
        new DateOnly(2021, 1, 1),
        360,
        1800,
        "Paid"
    ),
    new (
        2,
        "Jane Doe",
        50000,
        "Mortgage",
        new DateOnly(2023, 2, 1),
        360,
        4000,
        "Unpaid"
    ),
    new (
        3,
        "John Smith",
        100000,
        "Mortgage",
        new DateOnly(2022, 3, 1),
        360,
        900,
        "Unpaid"
    ),
    new (
        4,
        "Jane Smith",
        50000,
        "Mortgage",
        new DateOnly(2021, 4, 1),
        180,
        1800,
        "Paid"
    ),
    new (
        5,
        "John Johnson",
        1000000,
        "Mortgage",
        new DateOnly(2021, 5, 1),
        180,
        4200,
        "Unpaid"
    ),
    new (
        6,
        "Jane Johnson",
        600000,
        "Mortgage",
        new DateOnly(2021, 6, 1),
        180,
        3200,
        "Unpaid"
    ),
    new (
        7,
        "John Williams",
        250000,
        "Mortgage",
        new DateOnly(2021, 7, 1),
        180,
        2750,
        "Unpaid"
    ),
    new (
        8,
        "Jane Williams",
        100000,
        "Mortgage",
        new DateOnly(2021, 8, 1),
        360,
        2100,
        "Unpaid"
    ),
    new (
        9,
        "John Brown",
        780000,
        "Mortgage",
        new DateOnly(2021, 9, 1),
        180,
        3000,
        "Paid"
    ),
    new (
        10,
        "Jane Brown",
        265000,
        "Mortgage",
        new DateOnly(2021, 10, 1),
        180,
        1500,
        "Paid"
    ),
    new (
        11,
        "John Davis",
        800000,
        "Mortgage",
        new DateOnly(2021, 11, 1),
        360,
        2500,
        "Unpaid"
    ),
    new (
        12,
        "Jane Davis",
        520000,
        "Mortgage",
        new DateOnly(2021, 12, 1),
        180,
        2000,
        "Unpaid"
    ),
    new (
        13,
        "John Miller",
        295000,
        "Mortgage",
        new DateOnly(2022, 1, 1),
        360,
        2000,
        "Unpaid"
    ),
    new (
        14,
        "Jane Miller",
        165000,
        "Mortgage",
        new DateOnly(2022, 2, 1),
        180,
        2000,
        "Unpaid"
    ),
    new (
        15,
        "John Wilson",
        450000,
        "Mortgage",
        new DateOnly(2022, 3, 1),
        180,
        3000,
        "Unpaid"
    )
];
app.MapGet("loans", () => loans);


app.MapGet("/", () => "Hello World!");

app.Run();
