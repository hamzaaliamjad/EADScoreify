document.addEventListener('DOMContentLoaded', function () {
    
    
    var projectsList = document.querySelector('.project-boxes');
   
    document.querySelector('.messages-btn').addEventListener('click', function () {
      document.querySelector('.messages-section').classList.add('show');
    });
    
    document.querySelector('.messages-close').addEventListener('click', function() {
      document.querySelector('.messages-section').classList.remove('show');
    });
  });