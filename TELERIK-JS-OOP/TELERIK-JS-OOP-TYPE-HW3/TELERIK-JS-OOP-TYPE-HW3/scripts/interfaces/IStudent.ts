interface IStudent extends IPerson {
    studentId: number;
    courses: ICourse[];
    addCourse(course: ICourse): void;
    removeCourse(course: ICourse): ICourse;
    success(courses: ICourse[]): number;
}