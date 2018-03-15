using OrchardCore.Workflows.Display;
using OrchardCore.Workflows.Email.Activities;
using OrchardCore.Workflows.Email.ViewModels;
using OrchardCore.Workflows.Models;

namespace OrchardCore.Workflows.Email.Drivers
{
    public class EmailTaskDisplay : ActivityDisplayDriver<EmailTask, EmailTaskViewModel>
    {
        protected override void EditActivity(EmailTask activity, EmailTaskViewModel model)
        {
            model.SenderExpression = activity.Sender.Expression;
            model.RecipientsExpression = activity.Recipients.Expression;
            model.SubjectExpression = activity.Subject.Expression;
            model.Body = activity.Body.Expression;
        }

        protected override void UpdateActivity(EmailTaskViewModel model, EmailTask activity)
        {
            activity.Sender = new WorkflowExpression<string>(model.SenderExpression);
            activity.Recipients = new WorkflowExpression<string>(model.RecipientsExpression);
            activity.Subject = new WorkflowExpression<string>(model.SubjectExpression);
            activity.Body = new WorkflowExpression<string>(model.Body);
        }
    }
}