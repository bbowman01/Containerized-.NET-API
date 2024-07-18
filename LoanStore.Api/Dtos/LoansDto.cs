namespace Loans.Api.Dtos;

public record LoansDto(
    int Id,
    string BorrowerName,
    decimal Amount,
    string LoanType,
    DateOnly StartDate,
    int TermInMonths,
    int MonthlyPayment,
    string PayStatus);

