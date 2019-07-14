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
        sh 'dotnet publish /nologo /p:OutDir="out"'
        sh 'zip -r deploy.zip ./out'
        archiveArtifacts(artifacts: 'deploy.zip', onlyIfSuccessful: true)
      }
    }
  }
}