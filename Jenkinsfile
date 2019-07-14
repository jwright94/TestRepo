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
        sh 'dotnet restore'
      }
    }
    stage('Build') {
      steps {
        sh 'dotnet build'
        archiveArtifacts(artifacts: './bin/*.dll', onlyIfSuccessful: true)
      }
    }
  }
}