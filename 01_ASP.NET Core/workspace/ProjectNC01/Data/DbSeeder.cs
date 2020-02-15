namespace ProjectNC01.Data
{
    public class DbSeeder
    {
        private ProjectNC01Context _context;

        public DbSeeder(ProjectNC01Context context)
        {
            _context = context;
        }

        /*
        * async 는 Task와 함께 사용
        */
        public async Task SeedDatabase()
        {
            if ( !_context.Teachers.Any() )
            {
                List<TeacherModel> teachers = new List<TeacherModel>()
                {
                    new TeacherModel() { Name = "T1", Class = "C1" },
                    new TeacherModel() { Name = "T2", Class = "C2" },
                    new TeacherModel() { Name = "T3", Class = "C3" },
                    new TeacherModel() { Name = "T4", Class = "C4" }
                };

                /*
                 * AddRangeAsync : List 형태의 데이터 Insert 일 경우
                 * AddAsync : 단일 데이터 Insert 일 경우
                 */
                await _context.AddRangeAsync(teachers);
                await _context.SaveChangesAsync();
            }
        }
    }
}