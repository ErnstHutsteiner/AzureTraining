from flask import Flask, request
from flask_restx import Resource, Api


app = Flask(__name__)
api = Api(app)

@api.route('/hello')
@api.doc('I say hello and take no parameters')
class HelloWorld(Resource):
    @api.doc('I say hello')
    def get(self):
        return {'hello': 'world'}
    
@api.route('/servus')
@api.doc('I say Servus and take no parameters')
class Servus(Resource):
    @api.doc('I say Servus')
    def get(self):
        return {'Servus': '!'}
    
@api.route('/yourname')
@api.doc('post your name')
class YourName(Resource):
    def post(self):
        return request.json

if __name__ == '__main__':
    app.run(debug=True)