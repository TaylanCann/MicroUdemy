namespace FreeCourse.Services.Catalog.Dtos
{
    public class CourseCreateDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }

        public decimal Price { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }
        public FeatureDto Feature { get; set; }
        public string CategoryId { get; set; }
    }
}
