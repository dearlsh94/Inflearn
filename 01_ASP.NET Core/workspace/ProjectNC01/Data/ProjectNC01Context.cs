namespace ProjectNC01.Data
{
    public class ProjectNC01Context : DbContext
    {
        /*
         * ctor + tab + tab 시 자동완성 가능
         * base class에 환경설정 정보 전달
         */
        public ProjectNC01Context(DbContextOptions options) : base(options) {}
        
        /*
         * 객체와 DB Table 매핑
         * Model Class ID 속성 필드 선언 필수
         *
         * public DBSet <[Object Class]> [TableName] { get; set; }
         */
        public DBSet<Student> Students { get; set; }
        public DBSet<Teacher> Teachers { get; set; }
    }
}