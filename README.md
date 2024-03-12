Examination System
A desktop application for examination system where instructor can generate exam and students take exams and get their grades instantly.
Sign in as student/ instructor 
- Login as instructor first to add an exam (insert duration and select the courses that this instructor teach And add Questions, database would be updated in grid)
- Logout then login as student (student would only find in the exam list the courses which he is enrolled)
- Press button to get started (a random exam model random questions are generated)
- choose the correct answer and True-False from the combobox beside each question (if student has passed on submit button, the exam is submitted and grade reviewed in table with all exam that student take)
- press submit to get redirected to the grade page
- you can then choose to log out or go to your profile (if went back to profile you wouldn't find the exam that has just finished in the exam list)

- 
- ![Alt text](https://github.com/Mahmoud23199/Examination_system_WindowsForms/blob/Migration/UpdateERD.png)
  
Student (M-to-M) Course: This relationship indicates that a student can enroll in multiple courses, and a course can have multiple students. 
Student (1-to-M) StudentAnswer: Each student can have multiple answers to different questions. 
Student (M-to-M) Exam: A student can take multiple exams, and an exam can be taken by multiple students.
Course (1-to-1) Exam: Each course has one associated exam. 
Question (1-to-1) StudentAnswer: Each question has one corresponding student answer. 
Instructor (1-to-M) Question: An instructor can create multiple questions. 
Student (1-to-M) StudentHistory: This relationship indicates that each student can have multiple entries in their history. 
course(1-to-M) StudentHistory: that each course can have multiple entries in the student history.



