require 'sinatra'
require 'sinatra/reloader'
require 'json'
require 'date'

set :environment, :production
enable :reloader
disable :logging

get '/ping' do
  "pong"
end

post '/feedback' do
  message = JSON.parse(request.body.read)
  puts "feedback ====> #{message}"
  puts "#{message["type"]} #{message["content"]}"
  status 204
end

post '/quote' do
	message = JSON.parse(request.body.read)
	
	puts "#{request.request_method} #{request.path} #{request.body.read}"
	status 200
	"{\"quote\":0}"
end
