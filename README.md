# ST10461176_PROG_6212_POE
Contract Management Claim System
A modern, web-based application designed to streamline the process of submitting, reviewing, and approving academic claims for lecturers. Built with a focus on an intuitive, application-like user experience.

🚀 Features
Role-Based Access Control: Secure login for three distinct user roles.

Lecturers: Submit new claims and track their status in real-time.

Program Coordinators: Review claims and provide pre-approval or decline.

Academic Managers: Give final approval or rejection on pre-approved claims.

Application-Like UX: Single-Page Application (SPA) design ensures fast, fluid interactions without page reloads.

Real-Time Dashboard: Each user gets a personalized overview of relevant claims and tasks.

Transparent Tracking: Lecturers can see the entire progress of their claim through every stage of the workflow.

🛠️ Technology Stack
Frontend: React.js (or Vue.js/Angular) - For building the dynamic SPA.

Backend: Node.js with Express.js (or Django, Spring Boot) - MVC framework providing RESTful APIs.

Database: MongoDB (or PostgreSQL) - For flexible and scalable data storage.

Authentication: JWT (JSON Web Tokens) - For secure user sessions.


🚦 Getting Started
Prerequisites
Node.js (v16 or higher)

npm or yarn

MongoDB Atlas or a local MongoDB instance

Installation
Clone the repository:

bash
git clone https://github.com/your-username/contract-management-system.git
cd contract-management-system
Set up the Backend (API Server):

bash
cd backend
npm install
# Create a .env file based on .env.example and add your database URI and JWT secret
npm run dev
The API server will start on http://localhost:5000.

Set up the Frontend (Client):

bash
cd ../frontend
npm install
npm start
The client will start on http://localhost:3000.

👥 Default User Roles for Testing
The system seeds the database with sample users:

Lecturer: Email: lecturer@email.com | Password: password

Program Coordinator: Email: coordinator@email.com | Password: password

Academic Manager: Email: manager@email.com | Password: password

🧪 Testing
To run the test suites for both frontend and backend:

bash
# Run backend tests (from /backend directory)
npm test

# Run frontend tests (from /frontend directory)
npm test
📄 License
This project is licensed under the MIT License - see the LICENSE.md file for details.

🤝 Contributing
Fork the Project

Create your Feature Branch (git checkout -b feature/AmazingFeature)

Commit your Changes (git commit -m 'Add some AmazingFeature')

Push to the Branch (git push origin feature/AmazingFeature)

Open a Pull Request

Disclaimer: This is a portfolio project. Ensure all security best practices (like proper input sanitization, secure JWT storage, and environment variables) are fully implemented before any production use.