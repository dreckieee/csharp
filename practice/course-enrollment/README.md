# Course Enrollment
**Phase:** Phase 2 — Collections & Lists
Flattens nested course lists across multiple students using LINQ SelectMany, printing all enrollments and a deduplicated sorted course list.

## Concepts Practiced
- LINQ SelectMany — flattening nested collections
- Two-parameter SelectMany overload to preserve student name alongside course
- Distinct() to remove duplicate courses
- OrderBy() for alphabetical sorting
- Anonymous types with new { }

## Highlights
- 5 students each with 3 enrolled courses
- PrintAllEnrollment prints every student-course pair using SelectMany two-parameter overload
- PrintUniqueCourses chains SelectMany, Distinct, and OrderBy into one expression

## Rules Enforced
- 0 warnings before push
- One file per class
- private set on all Student properties
- Static utility class with no instantiation
- Variables declared at point of use

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.