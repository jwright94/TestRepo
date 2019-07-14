pipeline {
  agent any
  stages {
    stage('Hello') {
      parallel {
        stage('Hello') {
          steps {
            echo 'Hello World!'
          }
        }
        stage('Print Branch Name') {
          steps {
            sh 'echo ${BRANCH_NAME}'
          }
        }
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
        sh 'docker ps'
      }
    }
  }
}