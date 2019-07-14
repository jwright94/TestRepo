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
        sh 'dotnet publish --self-contained /nologo /p:OutDir="out"'
        sh '''tar -zcvf deploy.tar.gz ./out
'''
        archiveArtifacts(artifacts: 'deploy.tar.gz', onlyIfSuccessful: true)
      }
    }
  }
}