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
        sh 'dotnet publish --self-contained true --runtime \'linux-musl-x64\' /nologo /p:OutDir="out"'
        sh '''tar -zcvf deploy.tar.gz ./out
'''
        archiveArtifacts(artifacts: 'deploy.tar.gz', onlyIfSuccessful: true)
      }
    }
    stage('Pretend to do Stuff') {
      steps {
        sh 'sudo docker ps'
      }
    }
  }
}