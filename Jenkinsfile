pipeline {
  agent any
  stages {
    stage('Hello') {
      steps {
        echo 'Hello World!'
      }
    }
    stage('Restore') {
      steps {
        sh 'dotnet build'
      }
    }
    stage('Build') {
      steps {
        sh 'dotnet build'
      }
    }
  }
}