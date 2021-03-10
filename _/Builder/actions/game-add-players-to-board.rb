DddResourceBuilder.new
  .init
  .resource_key('action:game:add-players-to-board')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
