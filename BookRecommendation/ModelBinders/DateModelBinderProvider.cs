using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BookRecommendation.ModelBinders
{
    public class DateModelBinderProvider : IModelBinderProvider
    {
        private readonly string cutomDate;

        public DateModelBinderProvider(string _customDate)
        {
            cutomDate = _customDate;
        }
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentException(nameof(context));
            }
            if (context.Metadata.ModelType == typeof(DateTime) || context.Metadata.ModelType == typeof(DateTime?))
            {
                return new DateModelBinder(cutomDate);
            }
            return null;
        }
    }
}
