using Application.Domain.Enums.Payslip;
using Application.Helpers;

namespace Application.QueryParams.Payslip
{
  public class MemberPayslipQueryParams : PaginationParams
  {
    public PayslipOrderBy OrderBy { get; set; } = PayslipOrderBy.DateDesc;
    public DateTime? From { get; set; }
    public DateTime? To { get; set; }
    public Guid? SalaryCycleId { get; set; }
    public Guid? ProjectId { get; set; }
    public List<PayslipStatus> Status { get; set; } = new List<PayslipStatus>();
  }
}