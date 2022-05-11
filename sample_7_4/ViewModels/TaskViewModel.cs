using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;

namespace sample_7_4.ViewModels {
  [POCOViewModel]
  public class TaskViewModel {
    public virtual string Subject { get; set; }
    public virtual DateTime DueDate { get; set; }

    public TaskViewModel() {
      Subject = "Something important";
      DueDate = DateTime.Today.AddDays(1);
    }
  }
}