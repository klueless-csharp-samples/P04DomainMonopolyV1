DddResourceBuilder.new
  .init
  .resource_key('action:player:buy-get-out-of-jail')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
